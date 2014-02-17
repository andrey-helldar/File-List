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
        bool subfolder = true,
            fullpath = false;

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

                subfolder = cbSubfolder.Checked ? true : false;
                fullpath = cbFullPath.Checked ? true : false;

                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please, wait a few seconds...");
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var info = new DirectoryInfo(tbPath.Text);
            DirectoryInfo[] dirs = info.GetDirectories();

            var export = new List<string>();
            string tmp = "";

            if (subfolder)
            {
                export.Add("==================================================================");
                export.Add("\tParent directory");
                export.Add("-----------------------------------");

                // scan parent directory
                if (separator == "New Line")
                {
                    foreach (FileInfo file in info.GetFiles())
                    {
                        export.Add(Path.GetFileName(file.FullName));
                    }
                }
                else
                {
                    separator = separator == "space" ? " " : separator;

                    foreach (FileInfo file in info.GetFiles())
                    {
                        tmp += separator + Path.GetFileName(file.FullName);
                    }

                    tmp = tmp.Remove(0, separator.Length);

                    export.Add(tmp);
                }
                export.Add("");

                //scan subdirectory
                foreach (DirectoryInfo dir in dirs)
                {
                    export.Add("==================================================================");
                    export.Add("\t" + (fullpath ? dir.FullName : new DirectoryInfo(dir.FullName).Name));
                    export.Add("-----------------------------------");

                    if (separator == "New Line")
                    {
                        var tDir = new DirectoryInfo(dir.FullName);
                        foreach (FileInfo file in tDir.GetFiles())
                        {
                            export.Add(Path.GetFileName(file.FullName));
                        }
                    }
                    else
                    {
                        separator = separator == "space" ? " " : separator;

                        var tDir = new DirectoryInfo(dir.FullName);
                        foreach (FileInfo file in tDir.GetFiles())
                        {
                            tmp += separator + Path.GetFileName(file.FullName);
                        }

                        if (separator.Length == 1)
                        {
                            tmp = tmp.Remove(0, 1);
                        }
                        else
                        {
                            tmp = tmp.Remove(0, 2);
                        }

                        export.Add(tmp);
                    }
                    export.Add("");
                }
            }
            else
            {
                //scan parent directory
                if (separator == "New Line")
                {
                    foreach (FileInfo file in info.GetFiles())
                    {
                        export.Add(Path.GetFileName(file.FullName));
                    }
                }
                else
                {
                    separator = separator == "space" ? " " : separator;

                    foreach (FileInfo file in info.GetFiles())
                    {
                        tmp += separator + Path.GetFileName(file.FullName);
                    }

                    tmp = tmp.Remove(0, separator.Length);

                    export.Add(tmp);
                }
            }

            File.WriteAllLines(Application.StartupPath + "/files.txt", export);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = Application.StartupPath + "/files.txt";
            proc.Start();
        }
    }
}
