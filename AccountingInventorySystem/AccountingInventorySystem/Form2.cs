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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == textBox4.Text)
            {
                string sorgu = "UPDATE login set sifre=@Sifre WHERE kullanici_adi=@Kadi AND eposta=@Eposta";
                con = new SqlConnection("Server=DESKTOP-7178SVE\\SQLEXPRESS; Initial Catalog=muhasebe; Integrated Security=SSPI;");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@Kadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@Epsota", textBox2.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBox3.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Şifre değiştrime işlemi başarılı.");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreleri kontrol ediniz.");
            }
        }
    }
}
