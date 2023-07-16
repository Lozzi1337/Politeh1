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
    public partial class Form_Abiturientu : Form
    {
        public Form_Abiturientu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rimsou.ru/abiturient/kolichestvo-mest-dlya-priyoma/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DocksPostup Form_DocksPostup = new Form_DocksPostup();
            Form_DocksPostup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_NapravlenyaPodgotov Form_NapravlenyaPodgotov = new Form_NapravlenyaPodgotov();
            Form_NapravlenyaPodgotov.ShowDialog();
        }
    }
}
