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

        private void Btn_OutOpen_Click(object sender, EventArgs e)
        {
            OpenDlg(Tb_OutFile);
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
            String str,key, f,t;
            String[] keys;    

            str = Tb_Search.Text;
            if (Tb_InFile.Text.Length == 0) return;
            f = Tb_InFile.Text;
            t = Path.GetDirectoryName(f) + "\\" + Path.GetFileNameWithoutExtension(f);
            key = Tb_Search.Text;
            keys = key.Split(' ');
            for(int i = 0; i < keys.Count(); i++) 
            {
                t = t + "[" + keys[i] + "]";
            }
            Tb_OutFile.Text = t + Path.GetExtension(f);
        }
    }
}
