using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunfaDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shortcutFix();
        }

        private void shortcutFix()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string directory = textBox1.Text;
            string command = "attrib -h -r -s /s /d " + directory + ":\\*.*";
            startInfo.Arguments = command;
            Console.WriteLine(command);
            process.StartInfo = startInfo;
            process.Start();
        }

        private void aboutWindow(object sender, EventArgs e)
        {
            aboutPage about = new aboutPage();
            about.Show();
        }
    }
}
