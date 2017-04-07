using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace rensenWare_forcer
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32")]
        static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

        [DllImport("kernel32")]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, uint nSize, out uint nNumberOfBytesWritten);

        private const int LevelPtr = 0x4AEBD0;
        private const int ScorePtr = 0x4B0C44;

        private int handle;


        public frmMain()
        {
            InitializeComponent();

            apology.LinkClicked += new LinkLabelLinkClickedEventHandler(
                    (obj, arg) =>
                    {
                        var apDiag = new Apology();
                        apDiag.ShowDialog();
                    }
                );

            btnSee.Click += new EventHandler(
                    (obj, arg) =>
                    {
                        Process.Start("https://virustotal.com/ko/file/7bf5623f0a10dfa148a35bebd899b7758612f1693d2a9910f716cf15a921a76a/analysis/1491487316/");                    
                    }
                );

            new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    var processes = Process.GetProcessesByName("th12");
                    foreach (var process in processes)
                    {
                        try
                        {
                            handle = (int)process.Handle;
                        }
                        catch
                        {
                            break;
                        }

                        uint outvar;
                        var buffer = new byte[4];

                        var readLevel = ReadProcessMemory(handle, LevelPtr, buffer, 4, out outvar);
                        if (!readLevel)
                        {
                            break;
                        }
                        else if (BitConverter.ToInt32(buffer, 0) != 3)
                        {
                            LabelStatus.Invoke(new MethodInvoker(() =>
                            {
                                LabelStatus.Text = "TH12 Ready, Not LUNATIC";
                            }));
                        }
                        else
                        {
                            LabelStatus.Invoke(new MethodInvoker(() =>
                            {
                                LabelStatus.Text = "TH12 Ready";
                            }));
                        }

                        var readScore = ReadProcessMemory(handle, ScorePtr, buffer, 4, out outvar);
                        if (!readScore)
                        {
                            break;
                        }
                        else if (BitConverter.ToInt32(buffer, 0) < 20000000)
                        {
                            LabelScore.Invoke(new MethodInvoker(() =>
                            {
                                LabelScore.Text = BitConverter.ToInt32(buffer, 0).ToString();
                            }));
                        }

                        break;
                    }

                    Thread.Sleep(100);
                }
            })).Start();
        }

        private void KillAllThread(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            uint outvar;
            byte[] overscore = BitConverter.GetBytes(40000000);

            if (handle != 0)
            {
                var _try = WriteProcessMemory(handle, ScorePtr, overscore, 4, out outvar);
                if(!_try)
                {
                    MessageBox.Show("Failed to modify memory. try again.");
                    return;
                }
            }
        }
    }
}
