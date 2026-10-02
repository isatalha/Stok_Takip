using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Stok_Takip
{
    public partial class Form2 : Form
    {
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True");
        string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";
        SqlDataReader oku;

        public string gelenId;

        decimal fiyatOlustur()
        {
            if (!decimal.TryParse(yuzdelik.Text.Trim(), out decimal yuzde))
            {
                MessageBox.Show("Lütfen geçerli bir yüzdelik oranı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yuzdelik.Focus(); // İmleci doğrudan kutunun içine odaklar
                return 0; // İşlemi iptal edip 0 döner
            }
            else
            {
                decimal hesaplananSatis;

                baglanti = new SqlConnection(_baglanti);
                baglanti.Open();
                string sorgu = "SELECT buyingPrice FROM stokTakip WHERE bikeCode = '" + gelenId + "'";
                komut = new SqlCommand(sorgu, baglanti);
                decimal alisFiyati = Convert.ToDecimal(komut.ExecuteScalar());
                hesaplananSatis = ((alisFiyati * yuzde) / 100);
                hesaplananSatis = hesaplananSatis + alisFiyati;
                baglanti.Close();

                return hesaplananSatis;
            }
        }

        public Form2(string urunKodu)
        {
            InitializeComponent();
            gelenId = urunKodu;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM stokTakip WHERE bikeCode = @kod";
            SqlCommand komutYukle = new SqlCommand(sorgu, baglanti);
            komutYukle.Parameters.AddWithValue("@kod", gelenId);

            baglanti.Open();
            SqlDataReader oku = komutYukle.ExecuteReader();

            if (oku.Read())
            {
                // Kolon isimleriyle doğrudan eşleme (indeks karışıklığını önler):
                urunKodu.Text = oku["bikeCode"].ToString();
                urunAdi.Text = oku["bikeName"].ToString();
                alisFiyati.Text = oku["buyingPrice"].ToString();
                satisFiyati.Text = oku["sellingPrice"].ToString();

                string stok = oku["bikeStock"].ToString();
                stok1.Text = stok;
                guncelStok.Text = stok;
            }
            baglanti.Close();



        }

        private void urunKodu_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void artiBir_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeStock = bikeStock + 1 WHERE bikeCode = @kod";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", gelenId);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            stok1.Text = (Convert.ToInt32(stok1.Text) + 1).ToString();
            guncelStok.Text = (Convert.ToInt32(guncelStok.Text) + 1).ToString();
        }

        private void arti10_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeStock = bikeStock + 10 WHERE bikeCode = @kod";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", gelenId);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            stok1.Text = (Convert.ToInt32(stok1.Text) + 10).ToString();
            guncelStok.Text = (Convert.ToInt32(guncelStok.Text) + 10).ToString();
        }

        private void eksiBir_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeStock = bikeStock - 1 WHERE bikeCode = @kod AND bikeStock > 0";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", gelenId);

            baglanti.Open();
            int etkilenen =komut.ExecuteNonQuery();
            baglanti.Close();

            if (etkilenen == 0)
            {
                MessageBox.Show("Stokta yeterli ürün yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            stok1.Text = (Convert.ToInt32(stok1.Text) - 1).ToString();
            guncelStok.Text = (Convert.ToInt32(guncelStok.Text) - 1).ToString();
        }

        private void eksiOn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeStock = bikeStock - 10 WHERE bikeCode = @kod AND bikeStock > 10";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", gelenId);

            baglanti.Open();
            int etkilenen = komut.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenen == 0)
            {
                MessageBox.Show("Stokta yeterli ürün yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            stok1.Text = (Convert.ToInt32(stok1.Text) - 10).ToString();
            guncelStok.Text = (Convert.ToInt32(guncelStok.Text) - 10).ToString();
        }




        private void tavsiyeEdilenSatis_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = fiyatOlustur();
            tavsiyeEdilenSatis.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            decimal temizFiyat = Convert.ToDecimal(tavsiyeEdilenSatis.Text);
            string sorgu = "UPDATE stokTakip SET sellingPrice = " + temizFiyat + " WHERE bikeCode = '" + gelenId.Trim() + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            decimal a = fiyatOlustur();
            satisFiyati.Text = Convert.ToString(a);
            MessageBox.Show("Fiyat Basariyla Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}