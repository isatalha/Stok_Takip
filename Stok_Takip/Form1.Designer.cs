namespace Stok_Takip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            urunKodu = new TextBox();
            urunAdi = new TextBox();
            urunEkle = new Button();
            urunSil = new Button();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            satisFiyati = new TextBox();
            alisFiyati = new TextBox();
            stok = new TextBox();
            satis = new Button();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            totalPrice = new Label();
            cikisYap = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            kullaniciAdi = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kulOlustur = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(43, 45, 49);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 295F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(urunKodu, 1, 1);
            tableLayoutPanel1.Controls.Add(urunAdi, 1, 2);
            tableLayoutPanel1.Controls.Add(urunEkle, 2, 1);
            tableLayoutPanel1.Controls.Add(urunSil, 2, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(satisFiyati, 1, 3);
            tableLayoutPanel1.Controls.Add(alisFiyati, 1, 5);
            tableLayoutPanel1.Controls.Add(stok, 1, 4);
            tableLayoutPanel1.Controls.Add(satis, 2, 3);
            tableLayoutPanel1.Controls.Add(button1, 2, 5);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(totalPrice, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(750, 673);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 185, 195);
            label1.Location = new Point(75, 120);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 185, 195);
            label2.Location = new Point(93, 210);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı";
            // 
            // urunKodu
            // 
            urunKodu.Anchor = AnchorStyles.None;
            urunKodu.AutoCompleteMode = AutoCompleteMode.Suggest;
            urunKodu.BackColor = Color.FromArgb(56, 58, 64);
            urunKodu.BorderStyle = BorderStyle.FixedSingle;
            urunKodu.Font = new Font("Segoe UI", 13F);
            urunKodu.ForeColor = Color.White;
            urunKodu.Location = new Point(247, 117);
            urunKodu.Margin = new Padding(5);
            urunKodu.Name = "urunKodu";
            urunKodu.PlaceholderText = "Örn: D001";
            urunKodu.Size = new Size(200, 36);
            urunKodu.TabIndex = 1;
            // 
            // urunAdi
            // 
            urunAdi.Anchor = AnchorStyles.None;
            urunAdi.BackColor = Color.FromArgb(56, 58, 64);
            urunAdi.BorderStyle = BorderStyle.FixedSingle;
            urunAdi.Font = new Font("Segoe UI", 13F);
            urunAdi.ForeColor = Color.White;
            urunAdi.Location = new Point(247, 207);
            urunAdi.Margin = new Padding(5);
            urunAdi.Name = "urunAdi";
            urunAdi.PlaceholderText = "Örn: E-Bike";
            urunAdi.Size = new Size(200, 36);
            urunAdi.TabIndex = 2;
            // 
            // urunEkle
            // 
            urunEkle.Anchor = AnchorStyles.None;
            urunEkle.BackColor = Color.FromArgb(35, 165, 90);
            urunEkle.Cursor = Cursors.Hand;
            urunEkle.FlatAppearance.BorderSize = 0;
            urunEkle.FlatStyle = FlatStyle.Flat;
            urunEkle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            urunEkle.ForeColor = Color.White;
            urunEkle.Location = new Point(512, 107);
            urunEkle.Margin = new Padding(5);
            urunEkle.Name = "urunEkle";
            urunEkle.Size = new Size(211, 56);
            urunEkle.TabIndex = 6;
            urunEkle.Text = "Ürün Ekle";
            urunEkle.UseVisualStyleBackColor = false;
            urunEkle.Click += urunEkle_Click;
            // 
            // urunSil
            // 
            urunSil.Anchor = AnchorStyles.None;
            urunSil.BackColor = Color.FromArgb(218, 55, 60);
            urunSil.Cursor = Cursors.Hand;
            urunSil.FlatAppearance.BorderSize = 0;
            urunSil.FlatStyle = FlatStyle.Flat;
            urunSil.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            urunSil.ForeColor = Color.White;
            urunSil.Location = new Point(512, 197);
            urunSil.Margin = new Padding(5);
            urunSil.Name = "urunSil";
            urunSil.Size = new Size(211, 56);
            urunSil.TabIndex = 7;
            urunSil.Text = "Ürün Sil";
            urunSil.UseVisualStyleBackColor = false;
            urunSil.Click += urunSil_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(88, 101, 242);
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(192, 46);
            label6.TabIndex = 8;
            label6.Text = "BİRDEMİR";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(203, 22);
            label7.Name = "label7";
            label7.Size = new Size(168, 46);
            label7.TabIndex = 9;
            label7.Text = "BİSİKLET";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(180, 185, 195);
            label4.Location = new Point(77, 300);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 3;
            label4.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(180, 185, 195);
            label3.Location = new Point(87, 480);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 2;
            label3.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(180, 185, 195);
            label5.Location = new Point(138, 390);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 30);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            // 
            // satisFiyati
            // 
            satisFiyati.Anchor = AnchorStyles.None;
            satisFiyati.BackColor = Color.FromArgb(56, 58, 64);
            satisFiyati.BorderStyle = BorderStyle.FixedSingle;
            satisFiyati.Font = new Font("Segoe UI", 13F);
            satisFiyati.ForeColor = Color.White;
            satisFiyati.Location = new Point(247, 297);
            satisFiyati.Margin = new Padding(5);
            satisFiyati.Name = "satisFiyati";
            satisFiyati.PlaceholderText = "Örn: 15000";
            satisFiyati.Size = new Size(200, 36);
            satisFiyati.TabIndex = 3;
            // 
            // alisFiyati
            // 
            alisFiyati.Anchor = AnchorStyles.None;
            alisFiyati.BackColor = Color.FromArgb(56, 58, 64);
            alisFiyati.BorderStyle = BorderStyle.FixedSingle;
            alisFiyati.Font = new Font("Segoe UI", 13F);
            alisFiyati.ForeColor = Color.White;
            alisFiyati.Location = new Point(247, 477);
            alisFiyati.Margin = new Padding(5);
            alisFiyati.Name = "alisFiyati";
            alisFiyati.PlaceholderText = "Örn: 10000";
            alisFiyati.Size = new Size(200, 36);
            alisFiyati.TabIndex = 5;
            // 
            // stok
            // 
            stok.Anchor = AnchorStyles.None;
            stok.BackColor = Color.FromArgb(56, 58, 64);
            stok.BorderStyle = BorderStyle.FixedSingle;
            stok.Font = new Font("Segoe UI", 13F);
            stok.ForeColor = Color.White;
            stok.Location = new Point(247, 387);
            stok.Margin = new Padding(5);
            stok.Name = "stok";
            stok.PlaceholderText = "Örn: 10";
            stok.Size = new Size(200, 36);
            stok.TabIndex = 4;
            // 
            // satis
            // 
            satis.Anchor = AnchorStyles.None;
            satis.BackColor = Color.FromArgb(59, 130, 246);
            satis.Cursor = Cursors.Hand;
            satis.FlatAppearance.BorderSize = 0;
            satis.FlatStyle = FlatStyle.Flat;
            satis.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            satis.ForeColor = Color.White;
            satis.Location = new Point(512, 287);
            satis.Margin = new Padding(5);
            satis.Name = "satis";
            satis.Size = new Size(211, 56);
            satis.TabIndex = 8;
            satis.Text = "Satış Yap";
            satis.UseVisualStyleBackColor = false;
            satis.Click += satis_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(88, 101, 242);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(512, 467);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(211, 56);
            button1.TabIndex = 10;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(78, 80, 88);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(512, 377);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(211, 56);
            button2.TabIndex = 9;
            button2.Text = "Detay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(180, 185, 195);
            label8.Location = new Point(14, 642);
            label8.Name = "label8";
            label8.Size = new Size(183, 31);
            label8.TabIndex = 10;
            label8.Text = "Toplam Değer =";
            // 
            // totalPrice
            // 
            totalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalPrice.AutoSize = true;
            totalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            totalPrice.ForeColor = Color.FromArgb(35, 165, 90);
            totalPrice.Location = new Point(203, 642);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(46, 31);
            totalPrice.TabIndex = 1;
            totalPrice.Text = "0 ₺";
            // 
            // cikisYap
            // 
            cikisYap.Anchor = AnchorStyles.Right;
            cikisYap.BackColor = Color.FromArgb(218, 55, 60);
            cikisYap.Cursor = Cursors.Hand;
            cikisYap.FlatAppearance.BorderSize = 0;
            cikisYap.FlatStyle = FlatStyle.Flat;
            cikisYap.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            cikisYap.ForeColor = Color.White;
            cikisYap.Location = new Point(683, 5);
            cikisYap.Margin = new Padding(5);
            cikisYap.Name = "cikisYap";
            cikisYap.Size = new Size(110, 42);
            cikisYap.TabIndex = 12;
            cikisYap.Text = "Cikis Yap";
            cikisYap.UseVisualStyleBackColor = false;
            cikisYap.Click += cikisYap_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 627F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 601F));
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(750, 673);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 96.57795F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.42205334F));
            tableLayoutPanel2.Size = new Size(831, 0);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 31, 34);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 45, 49);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 45, 49);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 34, 37);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(220, 225, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 101, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(48, 50, 56);
            dataGridView1.Location = new Point(3, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(38, 40, 44);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(798, 445);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(30, 31, 34);
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 804F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.Controls.Add(kullaniciAdi, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(758, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 451F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel3.Size = new Size(823, 673);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kullaniciAdi.AutoSize = true;
            kullaniciAdi.ForeColor = Color.FromArgb(180, 185, 195);
            kullaniciAdi.Location = new Point(725, 6);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(76, 31);
            kullaniciAdi.TabIndex = 1;
            kullaniciAdi.Text = "label9";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(cikisYap);
            flowLayoutPanel1.Controls.Add(kulOlustur);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(798, 46);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // kulOlustur
            // 
            kulOlustur.Anchor = AnchorStyles.None;
            kulOlustur.BackColor = Color.FromArgb(35, 165, 90);
            kulOlustur.Cursor = Cursors.Hand;
            kulOlustur.FlatAppearance.BorderSize = 0;
            kulOlustur.FlatStyle = FlatStyle.Flat;
            kulOlustur.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            kulOlustur.ForeColor = Color.White;
            kulOlustur.Location = new Point(479, 5);
            kulOlustur.Margin = new Padding(5);
            kulOlustur.Name = "kulOlustur";
            kulOlustur.Size = new Size(194, 42);
            kulOlustur.TabIndex = 11;
            kulOlustur.Text = "Kullanici Olustur";
            kulOlustur.UseVisualStyleBackColor = false;
            kulOlustur.Click += kulOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(1581, 673);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 13.8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Uygulaması";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox satisFiyati;
        private TextBox alisFiyati;
        private TextBox urunKodu;
        private TextBox urunAdi;
        private TextBox stok;
        private Button urunEkle;
        private Button urunSil;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private Label label7;
        private Label totalPrice;
        private Label label8;
        private Button satis;
        private Label kullaniciAdi;
        private Button kulOlustur;
        private Button cikisYap;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}