using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _Hell_File_List
{
    public partial class fIndex : Form
    {
        string separator = "New Line";

        public fIndex()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            this.Icon = Properties.Resources.myicon;

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSeparator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            tbPath.Text = fbd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                separator = cbSeparator.Text;
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please, wait a few seconds...");
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var dir = new DirectoryInfo(tbPath.Text);
            var files = new List<string>();

            foreach (FileInfo file in dir.GetFiles())
            {
                files.Add(Path.GetFileName(file.FullName));
            }

            if (separator == "New Line")
            {
                File.WriteAllLines(Application.StartupPath + "/files.txt", files);
            }
            else
            {
                var tmp = "";
                separator = separator != "space" ? separator : " ";

                foreach (string val in files)
                {
                    tmp += separator + val;
                }

                if (separator.Length == 1)
                {
                    tmp = tmp.Remove(0, 1);
                }
                else
                {
                    tmp = tmp.Remove(0, 2);
                }
                File.WriteAllText(Application.StartupPath + "/files.txt", tmp);
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Application.StartupPath + "/files.txt";
            proc.Start();
            //proc.WaitForExit();
        }
    }
}
