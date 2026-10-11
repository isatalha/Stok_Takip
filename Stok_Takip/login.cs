using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class login : Form
    {

        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True");
        SqlDataReader oku;
        string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }



        private void giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM login WHERE username = @username AND password = @password";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@username", username.Text);
            komut.Parameters.AddWithValue("@password", sifre.Text);
            oku = komut.ExecuteReader();

            if (oku.Read())
            {

                user girisYapan = new user()
                {
                    username = oku["username"].ToString(),
                    access = Convert.ToInt32(oku["access"])
                };

                Form1 form1 = new Form1(girisYapan);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();





        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
