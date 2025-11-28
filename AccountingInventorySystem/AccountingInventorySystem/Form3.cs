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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void giris_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                string sorgu = "INSERT INTO login values(@Kadi, @Sifre, @Eposta)";
                con = new SqlConnection("Server=DESKTOP-7178SVE\\SQLEXPRESS; Initial Catalog=muhasebe; Integrated Security=SSPI;");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@Kadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@Eposta", textBox2.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBox3.Text);
                cmd.Parameters.AddWithValue("@Sifre2", textBox4.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Kayıt işlemi başarılı.");
                con.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmamaktadır.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
