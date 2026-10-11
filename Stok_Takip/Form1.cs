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

        public user _AktifKullanici;

        //"Host=db.jnxigomcttpneuaponhm.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=[SuuAVSG9xjdmV0kq];SSL Mode=Require;Trust Server Certificate=true"
        // postgresql://postgres:[YOUR-PASSWORD]@db.jnxigomcttpneuaponhm.supabase.co:5432/postgres

        public string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";



        public Form1(user girisYapan)
        {
            InitializeComponent();
            _AktifKullanici = girisYapan;
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

            dataGridView1.Columns["bikeCode"].HeaderText = "Ürün Kodu";
            dataGridView1.Columns["bikeName"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["bikeStock"].HeaderText = "Stok";
            dataGridView1.Columns["buyingPrice"].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns["sellingPrice"].HeaderText = "Satış Fiyatı";



        }

        void sil()
        {
            urunKodu.Clear();
            urunAdi.Clear();
            stok.Clear();
            alisFiyati.Clear();
            satisFiyati.Clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guncelle();
            decimal a = fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";

            kullaniciAdi.Text = ($"Mevcut Kullanici = {_AktifKullanici.username}");



            if (_AktifKullanici.access != 1)
            {
                label8.Visible = false;
                totalPrice.Visible = false;
                label3.Visible = false;
                alisFiyati.Visible = false;
                dataGridView1.Columns["buyingPrice"].Visible = false;
                button1.Visible = false;
                kulOlustur.Visible = false;

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sütun başlığına tıklandığında hataya düşmemesi için kontrol
            if (e.RowIndex < 0 || dataGridView1.CurrentRow == null)
                return;

            // ?.ToString() sayesinde veritabanında o alan boş (null) olsa bile program çökmez
            urunKodu.Text = dataGridView1.CurrentRow.Cells["bikeCode"].Value?.ToString() ?? "";
            urunAdi.Text = dataGridView1.CurrentRow.Cells["bikeName"].Value?.ToString() ?? "";
            alisFiyati.Text = dataGridView1.CurrentRow.Cells["buyingPrice"].Value?.ToString() ?? "";
            satisFiyati.Text = dataGridView1.CurrentRow.Cells["sellingPrice"].Value?.ToString() ?? "";
            stok.Text = dataGridView1.CurrentRow.Cells["bikeStock"].Value?.ToString() ?? "";
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

            sil();

            baglanti.Open();
            komut.ExecuteNonQuery();
            guncelle();
            decimal a = fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
            baglanti.Close();

            MessageBox.Show("Urun basariyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void urunSil_Click(object sender, EventArgs e)
        {

            bool onay = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;


            if (onay == true)
            {
                string sorgu = "DELETE FROM stokTakip WHERE bikeCode = @kod ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kod", urunKodu.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                guncelle();
                decimal a = fiyatGetir();
                totalPrice.Text = a.ToString("N2") + " TL";
                baglanti.Close();

                sil();

                MessageBox.Show("Urun basariyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void satis_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTakip SET bikeStock = bikeStock - 1 WHERE bikeCode = @kod AND bikeStock > 0";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", urunKodu.Text);
            baglanti.Open();
            int etkilenen = komut.ExecuteNonQuery();
            guncelle();
            baglanti.Close();

            if (etkilenen == 0)
            {
                MessageBox.Show("Stokta yeterli ürün yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu2 = "SELECT bikeStock FROM stokTakip WHERE bikeCode = @kod";
            komut = new SqlCommand(sorgu2, baglanti);
            komut.Parameters.AddWithValue("@kod", urunKodu.Text);

            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            stok.Text = oku["bikeStock"].ToString();
            baglanti.Close();

            MessageBox.Show("Satış başarılı, stok güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

            // satis grafigi icin databaseye veri ekleme

            string girilenKod = urunKodu.Text.Trim(); // Trim() sağdaki soldaki gizli boşlukları siler

            if (string.IsNullOrEmpty(girilenKod))
            {
                MessageBox.Show("HATA: TextBox boş algılandı! Lütfen yazdığınızdan emin olun.");
                return;
            }

            string kontrol = "SELECT COUNT(*) FROM satisTakip WHERE bikeCode = @kod AND CAST(date AS DATE) = @tarih";
            komut = new SqlCommand(kontrol, baglanti);
            komut.Parameters.AddWithValue("@kod", urunKodu.Text);
            komut.Parameters.AddWithValue(@"tarih", DateTime.Now.Date);
            baglanti.Open() ;
            int kontrolSonucu = (int)komut.ExecuteScalar();
            baglanti.Close();

            if (kontrolSonucu > 0)
            {
                string guncelleSorgu = "UPDATE satisTakip SET quantity = quantity + 1 WHERE bikeCode = @kod AND CAST(date AS DATE) = @tarih";
                komut = new SqlCommand(guncelleSorgu, baglanti);
                komut.Parameters.AddWithValue("@kod", urunKodu.Text);
                komut.Parameters.AddWithValue(@"tarih", DateTime.Now.Date);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                string ekleSorgu = "INSERT INTO satisTakip (bikeCode, quantity, date) VALUES (@kod, 1, @tarih)";
                komut = new SqlCommand(ekleSorgu, baglanti);
                komut.Parameters.AddWithValue("@kod", urunKodu.Text);
                komut.Parameters.AddWithValue(@"tarih", DateTime.Now.Date);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            sil();
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
            decimal a = fiyatGetir();
            totalPrice.Text = a.ToString("N2") + " TL";
            baglanti.Close();

            MessageBox.Show("Urun basariyla guncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["bikeCode"].Value != null)
            {
                string urunId = dataGridView1.CurrentRow.Cells["bikeCode"].Value.ToString();

                urunDetay form2 = new urunDetay(urunId, _AktifKullanici);

                form2.ShowDialog();


                guncelle();
                decimal a = fiyatGetir();
                totalPrice.Text = a.ToString("N2") + " TL";

            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sil();
        }
        public class UrunStokFiyat
        {
            public int stok { get; set; }
            public decimal fiyat { get; set; }
        }

        private void kulOlustur_Click(object sender, EventArgs e)
        {
            Form kayit = new kayit();
            kayit.ShowDialog();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            Form login = new login();
            this.Close();
            login.ShowDialog();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
