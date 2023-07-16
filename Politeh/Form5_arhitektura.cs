using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Politeh
{
    public partial class Form5_arhitektura : Form
    {
        public Form5_arhitektura()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/institut/kafedry/arhitektura-gradostroitelstvo-i-dizajn/");
        }
    }
}
