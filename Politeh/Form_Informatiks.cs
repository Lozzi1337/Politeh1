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
    public partial class Form_Informatiks : Form
    {
        public Form_Informatiks()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/institut/kafedry/informatika-i-informaczionnye-tehnologii/");
        }
    }
}
