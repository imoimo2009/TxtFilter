using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TxtFilter
{
    public partial class Form1 : Form
    {
        int gPrg;

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
            String[] fname;

            fname = (String[])e.Data.GetData(DataFormats.FileDrop, false);
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
                Title = "入力ファイルを開く",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
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
            String s, key, f, t;

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
                String[] keys;

                keys = key.Split(' ');
                for (int i = 0; i < keys.Count(); i++)
                {
                    t = t + "[" + keys[i] + "]";
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
            Exec_Filter();
            MessageBox.Show("抽出完了！");
        }

        private void Exec_Filter()
        {
            String in_path, out_path, search_value;
            String[] keys;
            StreamReader sr;
            StreamWriter sw;
            int max, cnt = 0;

            in_path = Tb_InFile.Text;
            out_path = Tb_OutFile.Text;
            search_value = Tb_Search.Text;
            keys = search_value.Split(' ');
            sr = new StreamReader(in_path);
            sw = new StreamWriter(out_path);
            progressBar1.Style = ProgressBarStyle.Marquee;
            max = File.ReadAllLines(in_path).Count();
            progressBar1.Style = ProgressBarStyle.Continuous;
            Timer1.Enabled = true;
            while (!sr.EndOfStream)
            {
                String s = sr.ReadLine();
                int sc = 0;
                foreach(String k in keys)
                {
                    if (s.IndexOf(k) > 0) sc++;
                }
                if (sc == keys.Count()) sw.WriteLine(s);
                cnt++;
                gPrg = cnt / max * 100;
            }
            sr.Close();
            sw.Close();
            Timer1.Enabled = false;
            progressBar1.Value = gPrg;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = gPrg;
            Application.DoEvents();
        }
    }
}
