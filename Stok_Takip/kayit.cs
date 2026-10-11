using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class kayit : Form
    {
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True");
        SqlDataReader oku;
        string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";

        public kayit()
        {
            InitializeComponent();
        }

        private void kayit_Load(object sender, EventArgs e)
        {
            kayitAccess.Text = "Yetki Seçiniz...";
            kayitAccess.ForeColor = Color.Gray;


        }

        private void kayitEt_Click(object sender, EventArgs e)
        {
            int yetki;
            baglanti.Open();
            string sorgu = "INSERT INTO login(username, password, access) VALUES (@username, @password, @access)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@username", kayitUsername.Text);
            komut.Parameters.AddWithValue("@password", kayitPassword.Text);

            if (kayitAccess.SelectedItem == null)
            {
                baglanti.Close();
                MessageBox.Show("Lutfen bir deger seciniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (kayitAccess.SelectedItem?.ToString() == "Yonetici")
            {
                yetki = 1;
               
            }
            else if (kayitAccess.SelectedItem?.ToString() == "Personel")
            {
                yetki = 2;
                
            }
            else if (kayitAccess.SelectedItem?.ToString() == "Misafir")
            {
                yetki = 3;
                
            }
            else
            {
                MessageBox.Show("Lütfen bir erişim türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
                return;
                
            }
            komut.Parameters.AddWithValue("@access", yetki);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
