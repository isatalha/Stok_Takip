using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;



namespace Stok_Takip
{
    public partial class urunDetay : Form
    {
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True");
        string _baglanti = @"server=.\SQLEXPRESS;Initial Catalog=stok_takip;Integrated Security=SSPI;TrustServerCertificate=True";
        SqlDataReader oku;
        List<double> gunler = new List<double>();
        private user _aktifKullanici;
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

        public urunDetay(string urunKodu, user gelenKullanici)
        {
            InitializeComponent();
            gelenId = urunKodu;
            _aktifKullanici = gelenKullanici;
        }

        public urunDetay()
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

            //Kullanici yetkisine gore butonalari gizle ve goster
            if (_aktifKullanici != null && _aktifKullanici.access == 2)
            {
                label3.Visible = false;
                label8.Visible = false;
                alisFiyati.Visible = false;
                yuzdelik.Visible = false;
                button1.Visible = false;
                tavsiyeEdilenSatis.Visible = false;
                fiyatGuncelle.Visible = false;

            }

            
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
            int etkilenen = komut.ExecuteNonQuery();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void tarihHesap_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePicker2.Value;
            DateTime bitis = dateTimePicker1.Value;
            TimeSpan fark = bitis - baslangic;
            int gunSayisi = (int)fark.TotalDays;

            if (baslangic > bitis)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sorgu = @"SELECT CAST(date AS DATE) AS date, quantity FROM satisTakip WHERE bikeCode = @kod AND CAST(date AS DATE) BETWEEN @baslangic AND @bitis ORDER BY CAST(date AS DATE) ASC";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kod", gelenId);
            komut.Parameters.AddWithValue("@baslangic", baslangic.Date);
            komut.Parameters.AddWithValue("@bitis", bitis.Date);

            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"{gelenId} kodlu ürün için bu tarih aralığında satış bulunamadı.");
                formsPlot1.Plot.Clear();
                formsPlot1.Refresh();
                return;
            }

            double[] xTarihler = new double[dt.Rows.Count];
            double[] yMiktarlar = new double[dt.Rows.Count];

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DateTime tarih = Convert.ToDateTime(dt.Rows[i]["date"]).Date;
                xTarihler[i] = tarih.ToOADate();
                yMiktarlar[i] = Convert.ToDouble(dt.Rows[i]["quantity"]);
            }

            formsPlot1.Plot.Clear();

            var bar = formsPlot1.Plot.Add.Bars(xTarihler, yMiktarlar);
            bar.Label = $"{gelenId} Satış Miktarı";
            foreach (var b in bar.Bars)
            {
                b.Size = 0.5;
                b.FillColor = ScottPlot.Color.FromColor(System.Drawing.Color.DodgerBlue).WithAlpha(200);
            }

            formsPlot1.Plot.Axes.DateTimeTicksBottom();

            formsPlot1.Plot.Title($"{gelenId} Satış Miktarı ({baslangic.ToShortDateString()} - {bitis.ToShortDateString()})");
            formsPlot1.Plot.XLabel("Tarih");
            formsPlot1.Plot.YLabel("Satış Miktarı");
            formsPlot1.Plot.ShowLegend();


            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Plot.Axes.SetLimitsY(0 , 0);

            formsPlot1.Refresh();






        }
    }
}