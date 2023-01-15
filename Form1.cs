using System.Diagnostics;
using System;
namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            DialogResult isStart = MessageBox.Show("If you a trying to run this game, \nyou need to first save your files, \nthe program may turn off your computer but without harm it.\nARE YOU SURE TO CONTINUE?", "Waring", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (isStart == DialogResult.OK)
            {
                this.SetVisibleCore(false);
                new Form2().ShowDialog();
            }
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Start;
            this.CancelButton = Quit;
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Hello World");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Hello World!!");
                }
                else
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}