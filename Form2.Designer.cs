namespace Game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StopProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBSODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAnswerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fillInTheBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useMessageBoxToShowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToNextQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSODNowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToTheNextQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(333, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 0;
            this.button4.Text = "Forfeit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressed);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.UpdateTime);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(245, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(12, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 29);
            this.progressBar1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correct!";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(337, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Incorrect!";
            this.label5.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopProcessToolStripMenuItem,
            this.jumpToTheNextQuestionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(273, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // StopProcessToolStripMenuItem
            // 
            this.StopProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartExplorerToolStripMenuItem,
            this.StopProcessesToolStripMenuItem,
            this.stopBSODToolStripMenuItem,
            this.showAnswerToolStripMenuItem1,
            this.stopTimerToolStripMenuItem,
            this.goToNextQuestionToolStripMenuItem,
            this.bSODNowToolStripMenuItem1});
            this.StopProcessToolStripMenuItem.Name = "StopProcessToolStripMenuItem";
            this.StopProcessToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.StopProcessToolStripMenuItem.Text = "Debug";
            // 
            // StartExplorerToolStripMenuItem
            // 
            this.StartExplorerToolStripMenuItem.Name = "StartExplorerToolStripMenuItem";
            this.StartExplorerToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.StartExplorerToolStripMenuItem.Text = "Start explorer.exe";
            this.StartExplorerToolStripMenuItem.Click += new System.EventHandler(this.StartExplorerToolStripMenuItem_Click);
            // 
            // StopProcessesToolStripMenuItem
            // 
            this.StopProcessesToolStripMenuItem.Name = "StopProcessesToolStripMenuItem";
            this.StopProcessesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.StopProcessesToolStripMenuItem.Text = "Close this window";
            this.StopProcessesToolStripMenuItem.Click += new System.EventHandler(this.StopProcessesToolStripMenuItem_Click);
            // 
            // stopBSODToolStripMenuItem
            // 
            this.stopBSODToolStripMenuItem.CheckOnClick = true;
            this.stopBSODToolStripMenuItem.Name = "stopBSODToolStripMenuItem";
            this.stopBSODToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.stopBSODToolStripMenuItem.Text = "Do not BSOD";
            // 
            // showAnswerToolStripMenuItem1
            // 
            this.showAnswerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillInTheBlankToolStripMenuItem,
            this.useMessageBoxToShowToolStripMenuItem1});
            this.showAnswerToolStripMenuItem1.Name = "showAnswerToolStripMenuItem1";
            this.showAnswerToolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.showAnswerToolStripMenuItem1.Text = "Show answer";
            // 
            // fillInTheBlankToolStripMenuItem
            // 
            this.fillInTheBlankToolStripMenuItem.Name = "fillInTheBlankToolStripMenuItem";
            this.fillInTheBlankToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.fillInTheBlankToolStripMenuItem.Text = "Fill in the blank";
            this.fillInTheBlankToolStripMenuItem.Click += new System.EventHandler(this.fillInTheBlankToolStripMenuItem_Click);
            // 
            // useMessageBoxToShowToolStripMenuItem1
            // 
            this.useMessageBoxToShowToolStripMenuItem1.Name = "useMessageBoxToShowToolStripMenuItem1";
            this.useMessageBoxToShowToolStripMenuItem1.Size = new System.Drawing.Size(281, 26);
            this.useMessageBoxToShowToolStripMenuItem1.Text = "Use message box to show";
            this.useMessageBoxToShowToolStripMenuItem1.Click += new System.EventHandler(this.useMessageBoxToShowToolStripMenuItem1_Click);
            // 
            // stopTimerToolStripMenuItem
            // 
            this.stopTimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.stopTimerToolStripMenuItem.Text = "Stop timer";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // goToNextQuestionToolStripMenuItem
            // 
            this.goToNextQuestionToolStripMenuItem.Name = "goToNextQuestionToolStripMenuItem";
            this.goToNextQuestionToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.goToNextQuestionToolStripMenuItem.Text = "Go to next question";
            this.goToNextQuestionToolStripMenuItem.Click += new System.EventHandler(this.goToNextQuestionToolStripMenuItem_Click);
            // 
            // bSODNowToolStripMenuItem1
            // 
            this.bSODNowToolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.bSODNowToolStripMenuItem1.Name = "bSODNowToolStripMenuItem1";
            this.bSODNowToolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.bSODNowToolStripMenuItem1.Text = "BSOD Now";
            this.bSODNowToolStripMenuItem1.Click += new System.EventHandler(this.BSODNowToolStripMenuItem1_Click);
            // 
            // jumpToTheNextQuestionToolStripMenuItem
            // 
            this.jumpToTheNextQuestionToolStripMenuItem.Name = "jumpToTheNextQuestionToolStripMenuItem";
            this.jumpToTheNextQuestionToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.jumpToTheNextQuestionToolStripMenuItem.Text = "Jump to thw next question";
            this.jumpToTheNextQuestionToolStripMenuItem.Click += new System.EventHandler(this.jumpToTheNextQuestionToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(337, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cheating!";
            this.label6.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Update);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(337, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pause!";
            this.label7.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(7, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Jump";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(11, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.Location = new System.Drawing.Point(7, 242);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(435, 29);
            this.progressBar2.TabIndex = 14;
            this.progressBar2.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(79, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(79, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 139);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(472, 186);
            this.MinimumSize = new System.Drawing.Size(472, 186);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem StopProcessToolStripMenuItem;
        private ToolStripMenuItem StartExplorerToolStripMenuItem;
        private ToolStripMenuItem StopProcessesToolStripMenuItem;
        private ToolStripMenuItem stopBSODToolStripMenuItem;
        private ToolStripMenuItem showAnswerToolStripMenuItem1;
        private ToolStripMenuItem fillInTheBlankToolStripMenuItem;
        private ToolStripMenuItem useMessageBoxToShowToolStripMenuItem1;
        private ToolStripMenuItem bSODNowToolStripMenuItem1;
        private ToolStripMenuItem goToNextQuestionToolStripMenuItem;
        private Label label6;
        private ToolStripMenuItem jumpToTheNextQuestionToolStripMenuItem;
        private ToolStripMenuItem stopTimerToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Button button2;
        private Button button1;
        private ProgressBar progressBar2;
        private Label label8;
        private Label label9;
    }
}