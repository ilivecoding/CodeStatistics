using System.Formats.Asn1;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;

namespace CodeStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateButton(true);
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        CancellationTokenSource cancellationTokenSource;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            
            await Task.Run(async () =>
            {
                await Start(txtPath.Text, ckbNoEmpty.Checked, ckbNoChild.Checked, txtSearchPattern.Text);
            }, cancellationTokenSource.Token);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void ResetProgress()
        {
            BeginInvoke(() =>
            {
                progressBar1.Maximum = 0;
                progressBar1.Value = 0;
            });
        }

        private void UpdateProgress(int maxValue)
        {
            BeginInvoke(() =>
            {
                if (reset)
                {
                    progressBar1.Maximum = maxValue;
                progressBar1.Value++;
            });
                }

        private void UpdateButton(bool enable)
                {
            BeginInvoke(() =>
            {
                btnStart.Enabled = enable;
                btnStop.Enabled = !enable;
            });
        }

        private void UpdateResult(string result)
        {
            BeginInvoke(() =>
            {
                richTextBox1.Text = result;
            });
        }

        private async Task Start(string fileDir, bool noEmpty, bool noChild, string searchPattern)
        {
            try
            {
                ResetProgress();
                UpdateButton(false);

                StatisticsResult statisticsResult = new StatisticsResult()
                {
                    NoEmpty = noEmpty,
                    NoChild = noChild,
                    Languages = new Dictionary<string, LanguageInfo> { },
                };

                var files = Directory.GetFiles(fileDir, searchPattern, noChild ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    cancellationTokenSource.Token.ThrowIfCancellationRequested();

                    var ext = new FileInfo(file).Extension.ToLower();
                    var txt = await File.ReadAllLinesAsync(file);
                    var lines = txt.Length;
                    if (noEmpty)
                    {
                        lines = txt.Where(x => !string.IsNullOrWhiteSpace(x)).Count();
                    }

                    if (!statisticsResult.Languages.ContainsKey(ext))
                    {
                        statisticsResult.Languages.Add(ext, new LanguageInfo()
                        {
                            Extension = ext,
                            Count = lines,
                        });
                    }
                    else
                    {
                        statisticsResult.Languages[ext].Count += lines;
                    }

                    UpdateProgress(files.Length);
                }

                var res = System.Text.Json.JsonSerializer.Serialize(statisticsResult, new System.Text.Json.JsonSerializerOptions()
                {
                    WriteIndented = true,
                });
                UpdateResult(res);
                UpdateButton(true);
                MessageBox.Show("Íê³É");
            }
            catch (Exception ex)
            {
                UpdateResult(string.Empty);
                ResetProgress();
                UpdateButton(true);
                MessageBox.Show(ex.Message);
            }
        }

    }
}

public class StatisticsResult
{
    public bool NoEmpty { get; set; }
    public bool NoChild { get; set; }
    public Dictionary<string, LanguageInfo> Languages { get; set; }
}

public class LanguageInfo
{
    public string Extension { get; set; }
    public int Count { get; set; }
}
