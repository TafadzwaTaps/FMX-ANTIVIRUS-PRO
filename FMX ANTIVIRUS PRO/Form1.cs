using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FMX_ANTIVIRUS_PRO
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string SS = "";
        private int CC = 0;
        private string VIRUSHARSHES = "";

        private void GET_VIRUSHARSHES()
        {
            var SSS = new StreamWriter(Application.StartupPath + @"\HASH.TXT");
            SSS.WriteLine("54KK3K4O33P20435K58VG23");
            SSS.Close();
            if (File.Exists(Application.StartupPath + @"\HASH.TXT") == true)
            {
                var S = new StreamReader(Application.StartupPath + @"\HASH.TXT");
                VIRUSHARSHES = S.ReadToEnd();
                S.Close();
            }
        }

        private void SCAN(string PATH)
        {
            var L = new List<FileInfo>();
            Label1.Text = "STATUS: ANALYSING";
            L.AddRange(GETFILES(PATH));
            Label1.Text = "STATUS: ABOUT TO START";
            foreach (FileInfo F in L)
            {
                if (BackgroundWorker1.CancellationPending == true)
                {
                    return;
                }
                else
                {
                    if (VIRUSHARSHES.Contains(GETMDS(F.FullName)) == true)
                    {
                        // DETECTED VIRUS
                        // WHAT WILL HAPPEN TO THE VIRUS DETECTED
                        ListView1.Items.Add(F.Name);
                        ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(F.FullName);
                        ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(F.Extension);
                        ListView1.Items[ListView1.Items.Count - 1].SubItems.Add(F.Length.ToString());
                        return;
                    }

                    CC += 1;
                    Label1.Text = CC + "; " + Environment.NewLine + F.FullName.ToString();
                }
            }
        }

        private List<FileInfo> GETFILES(string PATH)
        {
            var L = new List<FileInfo>();
            var D = new DirectoryInfo(PATH);
            FileInfo FX;
            foreach (DirectoryInfo DD in D.GetDirectories("*.*", SearchOption.AllDirectories))
            {
                foreach (FileInfo FF in DD.GetFiles())
                {
                    FX = new FileInfo(FF.FullName);
                    L.Add(FX);
                }

                L.AddRange(GETFILES(DD.FullName));
            }

            return L;
        }

        private string GETMDS(string PATH)
        {
            var MD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var F = new FileStream(PATH, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
            MD5.ComputeHash(F);
            F.Close();
            var hash = MD5.Hash;
            var buff = new StringBuilder();
            foreach (var hashbyte in hash)
                buff.Append(string.Format("{0:x2})", hashbyte));
            return buff.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker1.IsBusy == true)
            {
                if (Interaction.MsgBox("DO YOU WANT TO CANCEL SCANNING", MsgBoxStyle.YesNo, "SIMPLE ANTIVIRUS") == MsgBoxResult.Yes)
                {
                    BackgroundWorker1.CancelAsync();
                }
            }
            else if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                CC = 0;
                TextBox1.Text = FolderBrowserDialog1.SelectedPath;
                BackgroundWorker1.RunWorkerAsync();
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SCAN(FolderBrowserDialog1.SelectedPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            GET_VIRUSHARSHES();
        }
    }
}