namespace Stok_Takip
{
    partial class urunDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunDetay));
            tableLayoutPanel1 = new TableLayoutPanel();
            urunKodu = new Label();
            label1 = new Label();
            label2 = new Label();
            urunAdi = new Label();
            guncelStok = new Label();
            label4 = new Label();
            label6 = new Label();
            satisFiyati = new Label();
            label5 = new Label();
            stok1 = new Label();
            label3 = new Label();
            alisFiyati = new Label();
            label7 = new Label();
            yuzdelik = new TextBox();
            button1 = new Button();
            fiyatGuncelle = new Button();
            label8 = new Label();
            tavsiyeEdilenSatis = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            artiBir = new Button();
            arti10 = new Button();
            eksiBir = new Button();
            eksiOn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tarihHesap = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(43, 45, 49);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 351F));
            tableLayoutPanel1.Controls.Add(urunKodu, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(urunAdi, 1, 1);
            tableLayoutPanel1.Controls.Add(guncelStok, 1, 8);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 8);
            tableLayoutPanel1.Controls.Add(satisFiyati, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(stok1, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(alisFiyati, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 2, 6);
            tableLayoutPanel1.Controls.Add(yuzdelik, 0, 5);
            tableLayoutPanel1.Controls.Add(button1, 1, 5);
            tableLayoutPanel1.Controls.Add(fiyatGuncelle, 2, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(tavsiyeEdilenSatis, 1, 6);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 8);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(643, 862);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // urunKodu
            // 
            urunKodu.AutoSize = true;
            urunKodu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            urunKodu.ForeColor = Color.White;
            urunKodu.Location = new Point(240, 0);
            urunKodu.Name = "urunKodu";
            urunKodu.Size = new Size(158, 38);
            urunKodu.TabIndex = 0;
            urunKodu.Text = "urunKodu";
            urunKodu.Click += urunKodu_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 185, 195);
            label1.Location = new Point(39, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 5;
            label1.Text = "Ürün Kodu =";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 185, 195);
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(219, 38);
            label2.TabIndex = 6;
            label2.Text = "Ürün Modeli =";
            label2.Click += label2_Click;
            // 
            // urunAdi
            // 
            urunAdi.AutoSize = true;
            urunAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            urunAdi.ForeColor = Color.White;
            urunAdi.Location = new Point(240, 38);
            urunAdi.Name = "urunAdi";
            urunAdi.Size = new Size(133, 38);
            urunAdi.TabIndex = 1;
            urunAdi.Text = "urunAdi";
            // 
            // guncelStok
            // 
            guncelStok.Anchor = AnchorStyles.None;
            guncelStok.AutoSize = true;
            guncelStok.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            guncelStok.ForeColor = Color.FromArgb(59, 130, 246);
            guncelStok.Location = new Point(260, 383);
            guncelStok.Name = "guncelStok";
            guncelStok.Size = new Size(120, 46);
            guncelStok.TabIndex = 4;
            guncelStok.Text = "label6";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(180, 185, 195);
            label4.Location = new Point(42, 76);
            label4.Name = "label4";
            label4.Size = new Size(192, 38);
            label4.TabIndex = 8;
            label4.Text = "Satış Fiyatı =";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(180, 185, 195);
            label6.Location = new Point(11, 386);
            label6.Name = "label6";
            label6.Size = new Size(223, 41);
            label6.TabIndex = 5;
            label6.Text = "Güncel Stok =";
            // 
            // satisFiyati
            // 
            satisFiyati.Anchor = AnchorStyles.Left;
            satisFiyati.AutoSize = true;
            satisFiyati.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            satisFiyati.ForeColor = Color.FromArgb(35, 165, 90);
            satisFiyati.Location = new Point(240, 76);
            satisFiyati.Name = "satisFiyati";
            satisFiyati.Size = new Size(159, 38);
            satisFiyati.TabIndex = 3;
            satisFiyati.Text = "satisFiyati";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(180, 185, 195);
            label5.Location = new Point(127, 114);
            label5.Name = "label5";
            label5.Size = new Size(107, 38);
            label5.TabIndex = 9;
            label5.Text = "Stok =";
            // 
            // stok1
            // 
            stok1.Anchor = AnchorStyles.Left;
            stok1.AutoSize = true;
            stok1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            stok1.ForeColor = Color.FromArgb(59, 130, 246);
            stok1.Location = new Point(240, 114);
            stok1.Name = "stok1";
            stok1.Size = new Size(95, 38);
            stok1.TabIndex = 4;
            stok1.Text = "stok1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(180, 185, 195);
            label3.Location = new Point(57, 152);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 7;
            label3.Text = "Alış Fiyatı =";
            // 
            // alisFiyati
            // 
            alisFiyati.Anchor = AnchorStyles.Left;
            alisFiyati.AutoSize = true;
            alisFiyati.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            alisFiyati.ForeColor = Color.White;
            alisFiyati.Location = new Point(240, 152);
            alisFiyati.Name = "alisFiyati";
            alisFiyati.Size = new Size(143, 38);
            alisFiyati.TabIndex = 2;
            alisFiyati.Text = "alisFiyati";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 257);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // yuzdelik
            // 
            yuzdelik.Anchor = AnchorStyles.Right;
            yuzdelik.BackColor = Color.FromArgb(56, 58, 64);
            yuzdelik.BorderStyle = BorderStyle.FixedSingle;
            yuzdelik.Font = new Font("Segoe UI", 12F);
            yuzdelik.ForeColor = Color.White;
            yuzdelik.Location = new Point(113, 208);
            yuzdelik.Multiline = true;
            yuzdelik.Name = "yuzdelik";
            yuzdelik.PlaceholderText = "Kâr Oranı (%)";
            yuzdelik.Size = new Size(121, 31);
            yuzdelik.TabIndex = 12;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(88, 101, 242);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(266, 203);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 13;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fiyatGuncelle
            // 
            fiyatGuncelle.Anchor = AnchorStyles.Left;
            fiyatGuncelle.BackColor = Color.FromArgb(35, 165, 90);
            fiyatGuncelle.Cursor = Cursors.Hand;
            fiyatGuncelle.FlatAppearance.BorderSize = 0;
            fiyatGuncelle.FlatStyle = FlatStyle.Flat;
            fiyatGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fiyatGuncelle.ForeColor = Color.White;
            fiyatGuncelle.Location = new Point(406, 201);
            fiyatGuncelle.Name = "fiyatGuncelle";
            fiyatGuncelle.Size = new Size(114, 45);
            fiyatGuncelle.TabIndex = 6;
            fiyatGuncelle.Text = "Güncelle";
            fiyatGuncelle.UseVisualStyleBackColor = false;
            fiyatGuncelle.Click += button2_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(180, 185, 195);
            label8.Location = new Point(94, 276);
            label8.Name = "label8";
            label8.Size = new Size(140, 28);
            label8.TabIndex = 11;
            label8.Text = "Satış Değeri =";
            // 
            // tavsiyeEdilenSatis
            // 
            tavsiyeEdilenSatis.Anchor = AnchorStyles.Left;
            tavsiyeEdilenSatis.AutoSize = true;
            tavsiyeEdilenSatis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tavsiyeEdilenSatis.ForeColor = Color.FromArgb(35, 165, 90);
            tavsiyeEdilenSatis.Location = new Point(240, 262);
            tavsiyeEdilenSatis.Name = "tavsiyeEdilenSatis";
            tavsiyeEdilenSatis.Size = new Size(128, 56);
            tavsiyeEdilenSatis.TabIndex = 6;
            tavsiyeEdilenSatis.Text = "Hesaplanan Satış Değeri";
            tavsiyeEdilenSatis.Click += tavsiyeEdilenSatis_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(artiBir);
            flowLayoutPanel1.Controls.Add(arti10);
            flowLayoutPanel1.Controls.Add(eksiBir);
            flowLayoutPanel1.Controls.Add(eksiOn);
            flowLayoutPanel1.Location = new Point(406, 366);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(345, 81);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // artiBir
            // 
            artiBir.Anchor = AnchorStyles.None;
            artiBir.BackColor = Color.FromArgb(35, 165, 90);
            artiBir.Cursor = Cursors.Hand;
            artiBir.FlatAppearance.BorderSize = 0;
            artiBir.FlatStyle = FlatStyle.Flat;
            artiBir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            artiBir.ForeColor = Color.White;
            artiBir.Location = new Point(3, 3);
            artiBir.Name = "artiBir";
            artiBir.Size = new Size(110, 29);
            artiBir.TabIndex = 0;
            artiBir.Text = "+1";
            artiBir.UseVisualStyleBackColor = false;
            artiBir.Click += artiBir_Click;
            // 
            // arti10
            // 
            arti10.Anchor = AnchorStyles.None;
            arti10.BackColor = Color.FromArgb(35, 165, 90);
            arti10.Cursor = Cursors.Hand;
            arti10.FlatAppearance.BorderSize = 0;
            arti10.FlatStyle = FlatStyle.Flat;
            arti10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            arti10.ForeColor = Color.White;
            arti10.Location = new Point(119, 3);
            arti10.Name = "arti10";
            arti10.Size = new Size(110, 29);
            arti10.TabIndex = 1;
            arti10.Text = "+10";
            arti10.UseVisualStyleBackColor = false;
            arti10.Click += arti10_Click;
            // 
            // eksiBir
            // 
            eksiBir.Anchor = AnchorStyles.None;
            eksiBir.BackColor = Color.FromArgb(218, 55, 60);
            eksiBir.Cursor = Cursors.Hand;
            eksiBir.FlatAppearance.BorderSize = 0;
            eksiBir.FlatStyle = FlatStyle.Flat;
            eksiBir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            eksiBir.ForeColor = Color.White;
            eksiBir.Location = new Point(3, 38);
            eksiBir.Name = "eksiBir";
            eksiBir.Size = new Size(110, 29);
            eksiBir.TabIndex = 2;
            eksiBir.Text = "-1";
            eksiBir.UseVisualStyleBackColor = false;
            eksiBir.Click += eksiBir_Click;
            // 
            // eksiOn
            // 
            eksiOn.Anchor = AnchorStyles.None;
            eksiOn.BackColor = Color.FromArgb(218, 55, 60);
            eksiOn.Cursor = Cursors.Hand;
            eksiOn.FlatAppearance.BorderSize = 0;
            eksiOn.FlatStyle = FlatStyle.Flat;
            eksiOn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            eksiOn.ForeColor = Color.White;
            eksiOn.Location = new Point(119, 38);
            eksiOn.Name = "eksiOn";
            eksiOn.Size = new Size(110, 29);
            eksiOn.TabIndex = 3;
            eksiOn.Text = "-10";
            eksiOn.UseVisualStyleBackColor = false;
            eksiOn.Click += eksiOn_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(38, 40, 44);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 416F));
            tableLayoutPanel2.Controls.Add(formsPlot1, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(701, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 493F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 161F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(651, 862);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(57, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(583, 395);
            formsPlot1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dateTimePicker2);
            flowLayoutPanel2.Controls.Add(dateTimePicker1);
            flowLayoutPanel2.Controls.Add(tarihHesap);
            flowLayoutPanel2.Location = new Point(57, 496);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(591, 76);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(3, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(287, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(296, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // tarihHesap
            // 
            tarihHesap.Location = new Point(3, 36);
            tarihHesap.Name = "tarihHesap";
            tarihHesap.Size = new Size(164, 33);
            tarihHesap.TabIndex = 3;
            tarihHesap.Text = "button2";
            tarihHesap.UseVisualStyleBackColor = true;
            tarihHesap.Click += tarihHesap_Click;
            // 
            // urunDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(1352, 862);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "urunDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Detayları";
            Load += Form2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label urunKodu;
        private Label urunAdi;
        private Label alisFiyati;
        private Label satisFiyati;
        private Label stok1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button artiBir;
        private Button arti10;
        private Button eksiBir;
        private Button eksiOn;
        private Label guncelStok;
        private Label label6;
        private Label tavsiyeEdilenSatis;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox yuzdelik;
        private Button fiyatGuncelle;
        private FlowLayoutPanel flowLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private FlowLayoutPanel flowLayoutPanel2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button tarihHesap;
    }
}