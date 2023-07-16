using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Politeh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string vStrConnection = "Server = localhost; port = 5432; user id = postgres; password = 1982; database = postgres; ";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;
        
        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Abiturientu Form_Abiturientu = new Form_Abiturientu();
            Form_Abiturientu.Show();
        }
    }
}
