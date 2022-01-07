using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Renaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool CountFilesNumber = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (CountFilesNumber == true)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] dirs = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
                    foreach (string dir in dirs)
                    {
                        int num = 0;
                        var files = Directory.GetFiles(dir);
                        foreach (string file in files)
                        {
                            string newFileName;
                            if (Path.GetFileName(file).Contains('#'))
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('#')[0] + num + "#"+textbox3.Text + Path.GetExtension(file);
                            }
                            else
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('.')[0] + num + "#"+textbox3.Text + Path.GetExtension(file);
                            }
                            //MessageBox.Show(file +" =========== " + newFileName);
                            if (File.Exists(file))
                            {
                                File.Move(file, newFileName);

                            }
                        }
                    }
                    if (dirs.Count() == 0) {
                        int num = 0;
                        var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                        foreach (string file in files)
                        {
                            string newFileName;
                            if (Path.GetFileName(file).Contains('#'))
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('#')[0] + num + "#" + textbox3.Text + Path.GetExtension(file);
                            }
                            else
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('.')[0] + num + "#" + textbox3.Text + Path.GetExtension(file);
                            }
                            //MessageBox.Show(file +" =========== " + newFileName);
                            if (File.Exists(file))
                            {
                                File.Move(file, newFileName);

                            }
                        }
                    }
                }
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] dirs = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
                    foreach (string dir in dirs)
                    {
                        var files = Directory.GetFiles(dir);
                        foreach (string file in files)
                        {
                            string newFileName;
                            if (Path.GetFileName(file).Contains('#'))
                            {
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('#')[0] +  "#"+textbox3.Text + Path.GetExtension(file);
                            }
                            else
                            {
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('.')[0] +  "#"+textbox3.Text + Path.GetExtension(file);
                            }
                            //MessageBox.Show(file +" =========== " + newFileName);
                            if (File.Exists(file))
                            {
                                File.Move(file, newFileName);

                            }
                        }
                    }
                    if (dirs.Count() == 0)
                    {
                        int num = 0;
                        var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                        foreach (string file in files)
                        {
                            string newFileName;
                            if (Path.GetFileName(file).Contains('#'))
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('#')[0] + num + "#" + textbox3.Text + Path.GetExtension(file);
                            }
                            else
                            {
                                num++;
                                newFileName = Path.GetDirectoryName(file) + '\\' + Path.GetFileName(file).Split('.')[0] + num + "#" + textbox3.Text + Path.GetExtension(file);
                            }
                            //MessageBox.Show(file +" =========== " + newFileName);
                            if (File.Exists(file))
                            {
                                File.Move(file, newFileName);

                            }
                        }
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CountFilesNumber)
            {
                CountFilesNumber = false;
                button2.Text = "Count Numbers (OFF)";
            }
            else
            {
                CountFilesNumber = true;
                button2.Text = "Count Numbers (ON)";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float rest = float.Parse(textBox2.Text);
            for (float x = 0.0001f; x < 1000f; x += .0001f)
            {
                float divisor = x + rest;
                float dividend =x / divisor;
                float percentage=dividend*100f;

                int strPer=(int)percentage;
                if (strPer.ToString() == textBox1.Text)
                {
                    label3.Text = x.ToString();
                    MessageBox.Show("Done");
                    return;
                }
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
