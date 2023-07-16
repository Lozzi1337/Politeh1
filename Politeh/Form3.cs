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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5_arhitektura Form5_arhitektura = new Form5_arhitektura();
            Form5_arhitektura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5_menegers Form5_menegers = new Form5_menegers();
            Form5_menegers.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Informatiks Form_Informatiks = new Form_Informatiks();
            Form_Informatiks.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_PromishlennoeGrashdanstvo Form_PromishlennoeGrashdanstvo = new Form_PromishlennoeGrashdanstvo();
            Form_PromishlennoeGrashdanstvo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Energetics Form_Energetics = new Form_Energetics();
            Form_Energetics.Show();
        }
    }
}
