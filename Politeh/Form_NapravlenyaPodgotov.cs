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
    public partial class Form_NapravlenyaPodgotov : Form
    {
        public Form_NapravlenyaPodgotov()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/obrazovanie/programmy-bakalavriata-i-speczialiteta/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/obrazovanie/programmy-magistratury/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/obrazovanie/dopolnitelnoe-obrazovanie/");
        }
    }
}
