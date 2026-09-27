using Microsoft.Data.SqlClient;
using System.Data;

namespace Stok_Takip
{
    
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader oku;
        
        

        public string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";



        public Form1()
        {
            InitializeComponent();
        }

       
        public decimal fiyatGetir()
        {
            decimal toplam = 0;
            List<UrunStokFiyat> urunListesi = new List<UrunStokFiyat>();

            baglanti = new SqlConnection(_baglanti);
            baglanti.Open();

            string sorgu = "SELECT bikeStock,sellingPrice FROM stokTakip";
            komut = new SqlCommand(sorgu, baglanti);
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                UrunStokFiyat urun = new UrunStokFiyat()
                {
                    stok = Convert.ToInt32(oku["bikeStock"]),
                    fiyat = Convert.ToDecimal(oku["sellingPrice"]),
                };

                urunListesi.Add(urun);
            }
            
            foreach (var urun in urunListesi)
            {
                toplam += urun.stok * urun.fiyat;
            }
            baglanti.Close();

            return toplam;
        }

        void guncelle()
        {
            baglanti = new SqlConnection(_baglanti);
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM stokTakip", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guncelle();
            decimal a = fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunKodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            alisFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            satisFiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO stokTakip(bikeCode, bikeName, bikeStock, buyingPrice, sellingPrice) VALUES (@kod, @urunAdi, @stok, @alisFiyati, @satisFiyati)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", urunKodu.Text);
            komut.Parameters.AddWithValue("@urunAdi", urunAdi.Text);
            komut.Parameters.AddWithValue("@stok", Convert.ToInt32(stok.Text));
            komut.Parameters.AddWithValue("@alisFiyati", Convert.ToInt32(alisFiyati.Text));
            komut.Parameters.AddWithValue("@satisFiyati", Convert.ToInt32(satisFiyati.Text));

            urunKodu.Clear();
            urunAdi.Clear();
            stok.Clear();
            alisFiyati.Clear();
            satisFiyati.Clear();

            baglanti.Open();
            komut.ExecuteNonQuery();
            guncelle();
            decimal a= fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
            baglanti.Close();

            MessageBox.Show("Urun basariyla eklendi.");



        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM stokTakip WHERE bikeCode = @kod ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", urunKodu.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            guncelle();
            decimal a= fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
            baglanti.Close();

            urunKodu.Clear();
            urunAdi.Clear();
            stok.Clear();
            alisFiyati.Clear();
            satisFiyati.Clear();

            MessageBox.Show("Urun basariyla silindi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeCode=@kod, bikeName=@urunadi, bikeStock=@stok, buyingPrice=@alisFiyati, sellingPrice=@satisFiyati WHERE bikeCode=@kod";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@kod", urunKodu.Text);
            komut.Parameters.AddWithValue("@urunadi", urunAdi.Text);
            komut.Parameters.AddWithValue("@stok", stok.Text);
            komut.Parameters.AddWithValue("@alisFiyati", alisFiyati.Text);
            komut.Parameters.AddWithValue("satisFiyati", satisFiyati.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            guncelle();
            decimal a=fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
            baglanti.Close();

            MessageBox.Show("Urun basariyla guncellendi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["bikeCode"].Value != null)
            {
                string urunId = dataGridView1.CurrentRow.Cells["bikeCode"].Value.ToString();

                Form2 form2 = new Form2(urunId);
                form2.ShowDialog();


                guncelle();
                decimal a = fiyatGetir();
                totalPrice.Text = a.ToString("N2") + " TL";

            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir satır seçin.");
            }
        }
        public class UrunStokFiyat
        {
            public int stok { get; set; }
            public decimal fiyat { get; set; }
        }

    }
}
