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
    public partial class aboutPage : Form
    {
        public aboutPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Luk3M/FunfaDrive");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
