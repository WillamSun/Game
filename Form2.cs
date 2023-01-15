using System.ComponentModel;
using System.Diagnostics;

namespace Game
{
    public partial class Form2 : Form
    {
        Random ran = new();
        int first;
        int second;
        decimal times;
        int time;
        bool BSODing;
        int JumpTime;
        bool restartExplorer;
        int mode;
        double question;
        public Form2()
        {
            InitializeComponent();
        }

        private void Questing()
        {
            timer1.Start();
            first = ran.Next((int)Math.Pow(10.0, question), (int)Math.Pow(10.0, question + 1));
            second = ran.Next((int)Math.Pow(10.0, question), (int)Math.Pow(10.0, question + 1));
            label1.Text = first.ToString() + "+" + second.ToString();
        }
        void questing2()
        {
            timer1.Start();
            first = ran.Next((int)Math.Pow(10.0, question), (int)Math.Pow(10.0, question + 1));
            second = ran.Next((int)Math.Pow(10.0, question), (int)Math.Pow(10.0, question + 1));
            label1.Text = first.ToString() + "-" + second.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender != goToNextQuestionToolStripMenuItem && sender != jumpToTheNextQuestionToolStripMenuItem && button1.Text != "BSOD")
            {
                if (mode == 0)
                {
                    if (textBox1.Text != (first + second).ToString())
                    {
                        label5.Visible = true;
                        label4.Visible = false;
                        if (times / 100 == time)
                        {
                            new Thread(() => MessageBox.Show("Time's up!\nBSOD incoming!", "loser!!")).Start();
                            BSOD();
                        }
                        else
                        {
                            new Thread(() => MessageBox.Show("You are wrong!\nBSOD incoming!", "loser!!")).Start();
                            BSOD();
                        }
                    }
                    else
                    {
                        label5.Visible = false;
                        label4.Visible = true;
                        textBox1.Text = "";
                        question++;
                        timer1.Stop();
                        times = 0;
                        time += 5;
                        if (ran.Next(0, 2) == 0)
                        {
                            mode = 0;
                            Questing();
                        }
                        else
                        {
                            mode = 1;
                            questing2();
                        }
                    }
                }
                else if (mode == 1)
                {
                    if (textBox1.Text != (first - second).ToString())
                    {
                        label5.Visible = true;
                        label4.Visible = false;
                        if (times / 100 == time)
                        {
                            new Thread(() => MessageBox.Show("Time's up!\nBSOD incoming!", "loser!!")).Start();
                            BSOD();
                        }
                        else
                        {
                            new Thread(() => MessageBox.Show("You are wrong!\nBSOD incoming!", "loser!!")).Start();
                            BSOD();
                        }
                    }
                    else
                    {
                        label4.Visible = true;
                        label5.Visible = false;
                        textBox1.Text = "";
                        question++;
                        timer1.Stop();
                        times = 0;
                        time += 5;
                        if (ran.Next(0, 2) == 0)
                        {
                            Questing();
                            mode = 0;
                        }
                        else
                        {
                            questing2();
                            mode = 1;
                        }
                    }
                }
            }
            else if (sender == goToNextQuestionToolStripMenuItem)
            {
                textBox1.Text = "";
                question++;
                timer1.Stop();
                times = 0;
                time += 5;
                if (ran.Next(0, 2) == 0)
                {
                    Questing();
                    mode = 0;
                }
                else
                {
                    questing2();
                    mode = 1;
                }
            }
            else if (sender == jumpToTheNextQuestionToolStripMenuItem)
            {
                label6.Visible = true;
                textBox1.Text = "";
                question++;
                timer1.Stop();
                times = 0;
                time += 5;
                if (ran.Next(0, 2) == 0)
                {
                    Questing();
                    mode = 0;
                }
                else
                {
                    questing2();
                    mode = 1;
                }
            }
            else if (button1.Text == "BSOD") Run("BSOD", Application.ExecutablePath);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            int w = SystemInformation.WorkingArea.Width;
            int h = SystemInformation.WorkingArea.Height;
            Location = new Point(w / 2 - Width / 2, h / 2 - Height / 2);
            timer1.Stop();
            for (int i = 1; i < 8; i++) Run("StartWatchDog " + i.ToString(), Application.ExecutablePath);
            if (ran.Next(0, 2) == 0)
            {
                Questing();
                mode = 0;
            }
            else
            {
                questing2();
                mode = 1;
            }
            backgroundWorker1.RunWorkerAsync();
            AcceptButton = button1;
            CancelButton = button4;
            button1.TabIndex = 0;
            time = 5;
            TaskKill("CalculatorApp");
            TaskKill("Calc");
            TaskKill("explorer");
            timer1.Start();
        }
        private void keypressed(object o, KeyPressEventArgs e)
        {
            textBox1.ScrollToCaret();
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0' && e.KeyChar != '-') || e.KeyChar > '9') e.Handled = true;
                else if (textBox1.Text.Contains('-') && e.KeyChar == '-') e.Handled = true;
                else if (!textBox1.Text.Contains('-') && e.KeyChar == '-')
                {
                    e.Handled = true;
                    textBox1.Text = "-" + textBox1.Text;
                }
                if (!textBox1.Text.StartsWith("-") && textBox1.Text.Contains('-'))
                {
                    textBox1.Text = textBox1.Text.Replace("-", string.Empty);
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }
        private void UpdateTime(object sender, EventArgs e)
        {
            times += 1;
            if (times / 100 == time)
            {
                progressBar1.Value = 100;
                label2.Text = "Time's up! You lose!";
                label3.Text = "All the times gone!";
                button1_Click(sender, e);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!BSODing)
            {
                new Thread(() => MessageBox.Show("Why did you close the window?\nBSOD incoming!", "loser!!")).Start();
                BSOD();
            }
        }

        static void TaskKill(string ProcessName)
        {
            foreach (Process p in Process.GetProcesses())//GetProcessesByName(strProcessesByName))
            {
                if (p.ProcessName == ProcessName)
                {
                    try { p.Kill(); }
                    catch (Win32Exception) { Run("-F -IM " + ProcessName, "taskkill.exe"); }
                    catch (InvalidOperationException) { }
                }
            }

        }

        static bool Run(string Command, string Exec)
        {
            try
            {
                Process p = new();
                p.StartInfo.FileName = Exec;
                p.StartInfo.Arguments = Command;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                return true;
            }
            catch { return false; } 
        }
        private void BSOD()
        {
            BSODing = true;
            button1.Text = "BSOD";
            button1.Cursor = Cursors.Default;
            timer1.Stop();
            textBox1.Enabled = button4.Enabled = progressBar1.Enabled = label2.Enabled = label3.Enabled = false;
            Cursor = Cursors.No;
            if (stopBSODToolStripMenuItem.Checked) Run("BSOD", Application.ExecutablePath);
        }

        private void BSODNowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (MessageBox.Show("Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) BSOD();
            timer1.Enabled = true;
        }

        private void StartExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartExplorer = true;
            Run("","explorer.exe");
        }

        private void StopProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i++) TaskKill(Process.GetCurrentProcess().ProcessName);
            Environment.Exit(0);
        }
        
        private void fillInTheBlankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode == 0) textBox1.Text = (first + second).ToString();
            else if(mode == 1) textBox1.Text = (first - second).ToString();
        }

        private void useMessageBoxToShowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((mode == 0 ? (first + second) : (first - second)).ToString());
        }

        private void goToNextQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void jumpToTheNextQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            timer1.Enabled ^= true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            times = 0;
            timer1.Enabled = true;
        }

        private void Update(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!timer1.Enabled)
                {
                    label7.Visible = true;
                    stopToolStripMenuItem.Checked = true;
                }
                else
                {
                    label7.Visible = false;
                    stopToolStripMenuItem.Checked = false;
                }
                if (stopBSODToolStripMenuItem.Checked) stopBSODToolStripMenuItem.Checked = false;
                else stopBSODToolStripMenuItem.Checked = true;
                if (textBox1.Text.Contains('-') && !textBox1.Text.StartsWith("-")) textBox1.Text = "-" + textBox1.Text.Replace("-", "");
                label3.Text = "Already pass " + (times / 100) + "s";
                progressBar1.Value = (int)(100 / time * (times / 100));
                label2.Text = "Lose after " + (time - (times / 100)).ToString() + "s";
                if (label4.Visible) new Thread(() => { Thread.Sleep(2000); label4.Visible = false; }).Start();
                if (label6.Visible) new Thread(() => { Thread.Sleep(2000); label6.Visible = false; }).Start();
                Process[] myproc = Process.GetProcesses();
                foreach (Process item in myproc)
                {
                    if (item.ProcessName == "CalculatorApp" || item.ProcessName == "Calc")
                    {
                        item.Kill();
                        new Thread(() => MessageBox.Show("Why did you open the calculator?\nBSOD incoming!", "loser!!")).Start();
                        BSOD();
                    }
                    else if (item.ProcessName == "explorer") if (!restartExplorer) item.Kill();
                }
                Text = "Question" + (question + 1).ToString();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JumpTime += 1;
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                new Thread(() => MessageBox.Show("You admin!", "loser!!")).Start();
                BSOD();
            }
        }
    }
}