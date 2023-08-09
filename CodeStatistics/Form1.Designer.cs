namespace CodeStatistics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            txtSearchPattern = new TextBox();
            ckbNoChild = new CheckBox();
            progressBar1 = new ProgressBar();
            btnSelectPath = new Button();
            btnStop = new Button();
            btnStart = new Button();
            ckbNoEmpty = new CheckBox();
            txtPath = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            lbProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbProgress);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtSearchPattern);
            splitContainer1.Panel1.Controls.Add(ckbNoChild);
            splitContainer1.Panel1.Controls.Add(progressBar1);
            splitContainer1.Panel1.Controls.Add(btnSelectPath);
            splitContainer1.Panel1.Controls.Add(btnStop);
            splitContainer1.Panel1.Controls.Add(btnStart);
            splitContainer1.Panel1.Controls.Add(ckbNoEmpty);
            splitContainer1.Panel1.Controls.Add(txtPath);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 441;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "匹配：";
            // 
            // txtSearchPattern
            // 
            txtSearchPattern.Location = new Point(71, 144);
            txtSearchPattern.Name = "txtSearchPattern";
            txtSearchPattern.Size = new Size(238, 27);
            txtSearchPattern.TabIndex = 8;
            // 
            // ckbNoChild
            // 
            ckbNoChild.AutoSize = true;
            ckbNoChild.Location = new Point(71, 84);
            ckbNoChild.Name = "ckbNoChild";
            ckbNoChild.Size = new Size(106, 24);
            ckbNoChild.TabIndex = 7;
            ckbNoChild.Text = "不含子目录";
            ckbNoChild.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(71, 374);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(292, 29);
            progressBar1.TabIndex = 6;
            // 
            // btnSelectPath
            // 
            btnSelectPath.Location = new Point(315, 50);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.Size = new Size(48, 29);
            btnSelectPath.TabIndex = 5;
            btnSelectPath.Text = "...";
            btnSelectPath.UseVisualStyleBackColor = true;
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(171, 249);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 4;
            btnStop.Text = "停止";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(71, 249);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "开始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // ckbNoEmpty
            // 
            ckbNoEmpty.AutoSize = true;
            ckbNoEmpty.Location = new Point(71, 114);
            ckbNoEmpty.Name = "ckbNoEmpty";
            ckbNoEmpty.Size = new Size(91, 24);
            ckbNoEmpty.TabIndex = 2;
            ckbNoEmpty.Text = "不含空行";
            ckbNoEmpty.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(71, 51);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(238, 27);
            txtPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "路径：";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(355, 450);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // lbProgress
            // 
            lbProgress.AutoSize = true;
            lbProgress.Location = new Point(71, 351);
            lbProgress.Name = "lbProgress";
            lbProgress.Size = new Size(18, 20);
            lbProgress.TabIndex = 10;
            lbProgress.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "CodeStatistics";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSelectPath;
        private Button btnStop;
        private Button btnStart;
        private CheckBox ckbNoEmpty;
        private TextBox txtPath;
        private Label label1;
        private ProgressBar progressBar1;
        private CheckBox ckbNoChild;
        private RichTextBox richTextBox1;
        private TextBox txtSearchPattern;
        private Label label2;
        private Label lbProgress;
    }
}