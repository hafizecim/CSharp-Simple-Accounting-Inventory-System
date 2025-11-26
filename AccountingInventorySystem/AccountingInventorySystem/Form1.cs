using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountingInventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sifre_goster.Checked == true)
            {
                sifre.PasswordChar = '\0';
            }
            else
            {
                sifre.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From login Where kullanici_adi=@Kadi And sifre=@Sifre";
            con = new SqlConnection("Server=DESKTOP-7178SVE\\SQLEXPRESS; Initial Catalog=muhasebe; Integrated Security=SSPI;");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@Kadi",kullanici_adi.Text);
            cmd.Parameters.AddWithValue("@Sifre", sifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Girişiniz başarılı sonuçlanmıştır.");
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgileri tekrar kontorl ediniz.");
            }
            con.Close();
        }
    }
}
