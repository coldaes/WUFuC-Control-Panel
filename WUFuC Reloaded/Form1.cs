using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

namespace WUFuC_Reloaded
{
    public partial class Form1 : Form
    {
        private const bool V = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"script\enbl.bat"))
            {
                progressBar1.Value = 10;
                _ = Process.Start(@"script\enbl.bat");
                progressBar1.Value = 100;
                _ = MessageBox.Show("Sucessfully enabled WUFuC script!",
                               "Success",
                               buttons: MessageBoxButtons.OK);
            }
            else
            {
                progressBar1.Value = 100;
                _ = MessageBox.Show("Error: script file could not be found! Try re-installing the software.",
                                "Error 02",
                                buttons: MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                progressBar1.Value = 0;
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(@"licenses\license.txt"))
            {
                _ = Process.Start(@"licenses\license.txt");
            }
            else
            {
                _ = MessageBox.Show("Error: license file could not be found! Try re-installing the software.",
                                "Error 03",
                                buttons: MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"script\disb.bat"))
            {
                progressBar1.Value = 10;
                _ = Process.Start(@"script\disb.bat");
                progressBar1.Value = 100;
                _ = MessageBox.Show("Sucessfully disabled WUFuC script! You will still be able to check for updates until you restart.",
                           "Success",
                           buttons: MessageBoxButtons.OK);
            }
            else
            {
                progressBar1.Value = 100;
                _ = MessageBox.Show("Error: script file could not be found! Try re-installing the software.",
                                "Error 02",
                                buttons: MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                progressBar1.Value = 0;
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = Process.Start("https://github.com/git-coldsoft/WUFuC-Reloaded");
        }
    }
}
