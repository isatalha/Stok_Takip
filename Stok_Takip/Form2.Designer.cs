namespace Stok_Takip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            stok1 = new Label();
            satisFiyati = new Label();
            alisFiyati = new Label();
            urunAdi = new Label();
            urunKodu = new Label();
            tavsiyeEdilenSatis = new Label();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            yuzdelik = new TextBox();
            fiyatGuncelle = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            artiBir = new Button();
            arti10 = new Button();
            eksiOn = new Button();
            eksiBir = new Button();
            guncelStok = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 353F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(stok1, 1, 5);
            tableLayoutPanel1.Controls.Add(satisFiyati, 1, 4);
            tableLayoutPanel1.Controls.Add(alisFiyati, 1, 3);
            tableLayoutPanel1.Controls.Add(urunAdi, 1, 2);
            tableLayoutPanel1.Controls.Add(urunKodu, 1, 1);
            tableLayoutPanel1.Controls.Add(tavsiyeEdilenSatis, 1, 7);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 6);
            tableLayoutPanel1.Controls.Add(yuzdelik, 0, 6);
            tableLayoutPanel1.Controls.Add(fiyatGuncelle, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.Size = new Size(754, 869);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 604);
            label5.Name = "label5";
            label5.Size = new Size(110, 41);
            label5.TabIndex = 9;
            label5.Text = "Stok =";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 504);
            label4.Name = "label4";
            label4.Size = new Size(200, 41);
            label4.TabIndex = 8;
            label4.Text = "Satis Fiyati =";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 404);
            label3.Name = "label3";
            label3.Size = new Size(185, 41);
            label3.TabIndex = 7;
            label3.Text = "Alis Fiyati =";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 304);
            label2.Name = "label2";
            label2.Size = new Size(225, 41);
            label2.TabIndex = 6;
            label2.Text = "Urun Modeli =";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 204);
            label1.Name = "label1";
            label1.Size = new Size(207, 41);
            label1.TabIndex = 5;
            label1.Text = "Urun Kodu = ";
            // 
            // stok1
            // 
            stok1.Anchor = AnchorStyles.Left;
            stok1.AutoSize = true;
            stok1.Font = new Font("Segoe UI", 18F);
            stok1.Location = new Point(243, 604);
            stok1.Name = "stok1";
            stok1.Size = new Size(97, 41);
            stok1.TabIndex = 4;
            stok1.Text = "label5";
            // 
            // satisFiyati
            // 
            satisFiyati.Anchor = AnchorStyles.Left;
            satisFiyati.AutoSize = true;
            satisFiyati.Font = new Font("Segoe UI", 18F);
            satisFiyati.Location = new Point(243, 504);
            satisFiyati.Name = "satisFiyati";
            satisFiyati.Size = new Size(97, 41);
            satisFiyati.TabIndex = 3;
            satisFiyati.Text = "label4";
            // 
            // alisFiyati
            // 
            alisFiyati.Anchor = AnchorStyles.Left;
            alisFiyati.AutoSize = true;
            alisFiyati.Font = new Font("Segoe UI", 18F);
            alisFiyati.Location = new Point(243, 404);
            alisFiyati.Name = "alisFiyati";
            alisFiyati.Size = new Size(97, 41);
            alisFiyati.TabIndex = 2;
            alisFiyati.Text = "label3";
            // 
            // urunAdi
            // 
            urunAdi.Anchor = AnchorStyles.Left;
            urunAdi.AutoSize = true;
            urunAdi.Font = new Font("Segoe UI", 18F);
            urunAdi.Location = new Point(243, 304);
            urunAdi.Name = "urunAdi";
            urunAdi.Size = new Size(97, 41);
            urunAdi.TabIndex = 1;
            urunAdi.Text = "label2";
            // 
            // urunKodu
            // 
            urunKodu.Anchor = AnchorStyles.Left;
            urunKodu.AutoSize = true;
            urunKodu.Font = new Font("Segoe UI", 18F);
            urunKodu.Location = new Point(243, 204);
            urunKodu.Name = "urunKodu";
            urunKodu.Size = new Size(97, 41);
            urunKodu.TabIndex = 0;
            urunKodu.Text = "label1";
            urunKodu.Click += urunKodu_Click;
            // 
            // tavsiyeEdilenSatis
            // 
            tavsiyeEdilenSatis.Anchor = AnchorStyles.Left;
            tavsiyeEdilenSatis.AutoSize = true;
            tavsiyeEdilenSatis.Font = new Font("Segoe UI", 18F);
            tavsiyeEdilenSatis.Location = new Point(243, 800);
            tavsiyeEdilenSatis.Name = "tavsiyeEdilenSatis";
            tavsiyeEdilenSatis.Size = new Size(327, 41);
            tavsiyeEdilenSatis.TabIndex = 6;
            tavsiyeEdilenSatis.Text = "hesaplanan satis degeri";
            tavsiyeEdilenSatis.Click += tavsiyeEdilenSatis_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(21, 800);
            label8.Name = "label8";
            label8.Size = new Size(216, 41);
            label8.TabIndex = 11;
            label8.Text = "Satis Degeri =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(329, 698);
            button1.Name = "button1";
            button1.Size = new Size(174, 49);
            button1.TabIndex = 13;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yuzdelik
            // 
            yuzdelik.Anchor = AnchorStyles.None;
            yuzdelik.Font = new Font("Segoe UI", 18F);
            yuzdelik.Location = new Point(13, 699);
            yuzdelik.Name = "yuzdelik";
            yuzdelik.PlaceholderText = "Kar Orani";
            yuzdelik.Size = new Size(214, 47);
            yuzdelik.TabIndex = 12;
            // 
            // fiyatGuncelle
            // 
            fiyatGuncelle.Anchor = AnchorStyles.None;
            fiyatGuncelle.Font = new Font("Segoe UI", 18F);
            fiyatGuncelle.Location = new Point(596, 790);
            fiyatGuncelle.Name = "fiyatGuncelle";
            fiyatGuncelle.Size = new Size(154, 60);
            fiyatGuncelle.TabIndex = 6;
            fiyatGuncelle.Text = "Guncelle";
            fiyatGuncelle.UseVisualStyleBackColor = true;
            fiyatGuncelle.Click += button2_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.Controls.Add(artiBir, 1, 2);
            tableLayoutPanel2.Controls.Add(arti10, 1, 1);
            tableLayoutPanel2.Controls.Add(eksiOn, 1, 5);
            tableLayoutPanel2.Controls.Add(eksiBir, 1, 4);
            tableLayoutPanel2.Controls.Add(guncelStok, 1, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(839, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.Size = new Size(470, 869);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // artiBir
            // 
            artiBir.Anchor = AnchorStyles.None;
            artiBir.Location = new Point(290, 271);
            artiBir.Name = "artiBir";
            artiBir.Size = new Size(137, 62);
            artiBir.TabIndex = 0;
            artiBir.Text = "+1";
            artiBir.UseVisualStyleBackColor = true;
            artiBir.Click += artiBir_Click;
            // 
            // arti10
            // 
            arti10.Anchor = AnchorStyles.None;
            arti10.Location = new Point(290, 150);
            arti10.Name = "arti10";
            arti10.Size = new Size(137, 62);
            arti10.TabIndex = 1;
            arti10.Text = "+10";
            arti10.UseVisualStyleBackColor = true;
            arti10.Click += arti10_Click;
            // 
            // eksiOn
            // 
            eksiOn.Anchor = AnchorStyles.None;
            eksiOn.Location = new Point(290, 634);
            eksiOn.Name = "eksiOn";
            eksiOn.Size = new Size(137, 62);
            eksiOn.TabIndex = 3;
            eksiOn.Text = "-10";
            eksiOn.UseVisualStyleBackColor = true;
            eksiOn.Click += eksiOn_Click;
            // 
            // eksiBir
            // 
            eksiBir.Anchor = AnchorStyles.None;
            eksiBir.Location = new Point(290, 513);
            eksiBir.Name = "eksiBir";
            eksiBir.Size = new Size(137, 62);
            eksiBir.TabIndex = 2;
            eksiBir.Text = "-1";
            eksiBir.UseVisualStyleBackColor = true;
            eksiBir.Click += eksiBir_Click;
            // 
            // guncelStok
            // 
            guncelStok.Anchor = AnchorStyles.None;
            guncelStok.AutoSize = true;
            guncelStok.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guncelStok.Location = new Point(305, 403);
            guncelStok.Name = "guncelStok";
            guncelStok.Size = new Size(107, 41);
            guncelStok.TabIndex = 4;
            guncelStok.Text = "label6";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 403);
            label6.Name = "label6";
            label6.Size = new Size(223, 41);
            label6.TabIndex = 5;
            label6.Text = "Guncel Stok =";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 869);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urun Detaylari";
            Load += Form2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
    }
}