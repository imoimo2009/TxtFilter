using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static TxtFilter.Constants;

namespace TxtFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tb_InFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Tb_InFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] fname;

            fname = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Tb_InFile.Text = fname[0];
        }

        private void Btn_InOpen_Click(object sender, EventArgs e)
        {
            OpenDlg(Tb_InFile);
        }

        private void OpenDlg(TextBox tb)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = FILEDLG_TITLE,
                Filter = FILEDLG_FILTER,
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = ofd.FileName;
            }
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            Update_OutFile();
        }

        private void Update_OutFile()
        {
            string s, key, f, t;

            s = Tb_Search.Text;
            f = Tb_InFile.Text;
            if (f.Length == 0) return;
            if (Path.GetDirectoryName(f) != "")
            {
                t = Path.GetDirectoryName(f) + "\\";
            }
            else
            {
                t = "";
            }
            t += Path.GetFileNameWithoutExtension(f);
            key = Tb_Search.Text;
            if (key.Length > 0)
            {
                string[] keys;

                keys = key.Split(' ');
                foreach (string k in keys)
                {
                    t = t + "[" + k + "]";
                }
            }
            Tb_OutFile.Text = t + Path.GetExtension(f);
        }

        private void Tb_InFile_TextChanged(object sender, EventArgs e)
        {
            Update_OutFile();
        }

        private void Tb_InFile_Leave(object sender, EventArgs e)
        {
            Update_OutFile();
        }

        private void Btn_Exec_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            Btn_Exec.Enabled = false;
            BackgroundWorker1.WorkerReportsProgress = true;
            BackgroundWorker1.RunWorkerAsync(new String[] { Tb_Search.Text,Tb_InFile.Text,Tb_OutFile.Text });
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            int max, cnt = 0, prg = 0;
            string[] arg = e.Argument as string[];
            string[] keys = arg[SEARCH_KEY].Split(' ');
            StreamReader sr = new StreamReader(arg[INFILE_NAME]);
            StreamWriter sw = new StreamWriter(arg[OUTFILE_NAME]);
            
            max = File.ReadAllLines(arg[INFILE_NAME]).Count();
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                int sc = 0;
                foreach (string k in keys)
                {
                    if (s.IndexOf(k) >= 0) sc++;
                }
                if (sc == keys.Count()) sw.WriteLine(s);
                cnt++;
                if (prg < cnt / max * 100)
                {
                    prg = cnt / max * 100;
                    bw.ReportProgress(prg);
                }
            }
            sr.Close();
            sw.Close();
            e.Result = prg;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBar1.Style == ProgressBarStyle.Marquee)
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
            }
            int prg = e.ProgressPercentage;
            if (prg < progressBar1.Maximum)
            {
                progressBar1.Value = prg + 1;
                progressBar1.Value = prg;
            }
            else
            {
                progressBar1.Maximum++;
                progressBar1.Value = prg + 1;
                progressBar1.Value = prg;
                progressBar1.Maximum--;
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value = (int)e.Result;
                MessageBox.Show(COMPLETE_MSG);
            }
            Btn_Exec.Enabled = true;
        }
    }
}
