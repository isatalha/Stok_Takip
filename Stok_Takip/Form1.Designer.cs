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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            totalPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            urunKodu = new TextBox();
            urunAdi = new TextBox();
            urunEkle = new Button();
            urunSil = new Button();
            button1 = new Button();
            button2 = new Button();
            alisFiyati = new TextBox();
            satisFiyati = new TextBox();
            stok = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            satis = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 295F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(totalPrice, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(urunKodu, 1, 1);
            tableLayoutPanel1.Controls.Add(urunAdi, 1, 2);
            tableLayoutPanel1.Controls.Add(urunEkle, 2, 1);
            tableLayoutPanel1.Controls.Add(urunSil, 2, 2);
            tableLayoutPanel1.Controls.Add(button1, 2, 3);
            tableLayoutPanel1.Controls.Add(button2, 2, 5);
            tableLayoutPanel1.Controls.Add(alisFiyati, 1, 3);
            tableLayoutPanel1.Controls.Add(satisFiyati, 1, 4);
            tableLayoutPanel1.Controls.Add(stok, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(satis, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(750, 673);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 119);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 0;
            label1.Text = "Urun Kodu";
            // 
            // totalPrice
            // 
            totalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(203, 642);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(76, 31);
            totalPrice.TabIndex = 1;
            totalPrice.Text = "label8";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 209);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 1;
            label2.Text = "Urun Adi";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 299);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 2;
            label3.Text = "Alis Fiyati";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 389);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 3;
            label4.Text = "Satis Fiyati";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(138, 479);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            // 
            // urunKodu
            // 
            urunKodu.Anchor = AnchorStyles.None;
            urunKodu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urunKodu.Location = new Point(253, 116);
            urunKodu.Margin = new Padding(5);
            urunKodu.Name = "urunKodu";
            urunKodu.PlaceholderText = "Orn: D001";
            urunKodu.Size = new Size(189, 38);
            urunKodu.TabIndex = 5;
            // 
            // urunAdi
            // 
            urunAdi.Anchor = AnchorStyles.None;
            urunAdi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urunAdi.Location = new Point(253, 206);
            urunAdi.Margin = new Padding(5);
            urunAdi.Name = "urunAdi";
            urunAdi.PlaceholderText = "Orn: E-Bike";
            urunAdi.Size = new Size(189, 38);
            urunAdi.TabIndex = 6;
            // 
            // urunEkle
            // 
            urunEkle.Anchor = AnchorStyles.None;
            urunEkle.Font = new Font("Segoe UI", 13.8F);
            urunEkle.Location = new Point(512, 101);
            urunEkle.Margin = new Padding(5);
            urunEkle.Name = "urunEkle";
            urunEkle.Size = new Size(211, 68);
            urunEkle.TabIndex = 1;
            urunEkle.Text = "Ekle";
            urunEkle.UseVisualStyleBackColor = true;
            urunEkle.Click += urunEkle_Click;
            // 
            // urunSil
            // 
            urunSil.Anchor = AnchorStyles.None;
            urunSil.Font = new Font("Segoe UI", 13.8F);
            urunSil.Location = new Point(512, 191);
            urunSil.Margin = new Padding(5);
            urunSil.Name = "urunSil";
            urunSil.Size = new Size(211, 68);
            urunSil.TabIndex = 2;
            urunSil.Text = "Sil";
            urunSil.UseVisualStyleBackColor = true;
            urunSil.Click += urunSil_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new Point(512, 281);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(211, 68);
            button1.TabIndex = 3;
            button1.Text = "Guncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(512, 461);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(211, 68);
            button2.TabIndex = 4;
            button2.Text = "Detay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // alisFiyati
            // 
            alisFiyati.Anchor = AnchorStyles.None;
            alisFiyati.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alisFiyati.Location = new Point(253, 296);
            alisFiyati.Margin = new Padding(5);
            alisFiyati.Name = "alisFiyati";
            alisFiyati.PlaceholderText = "Orn: 10000";
            alisFiyati.Size = new Size(189, 38);
            alisFiyati.TabIndex = 6;
            // 
            // satisFiyati
            // 
            satisFiyati.Anchor = AnchorStyles.None;
            satisFiyati.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            satisFiyati.Location = new Point(253, 386);
            satisFiyati.Margin = new Padding(5);
            satisFiyati.Name = "satisFiyati";
            satisFiyati.PlaceholderText = "Orn: 15000";
            satisFiyati.Size = new Size(189, 38);
            satisFiyati.TabIndex = 6;
            // 
            // stok
            // 
            stok.Anchor = AnchorStyles.None;
            stok.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stok.Location = new Point(253, 476);
            stok.Margin = new Padding(5);
            stok.Name = "stok";
            stok.PlaceholderText = "Orn : 10";
            stok.Size = new Size(189, 38);
            stok.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(192, 46);
            label6.TabIndex = 8;
            label6.Text = "BIRDEMIR";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold);
            label7.Location = new Point(203, 22);
            label7.Name = "label7";
            label7.Size = new Size(168, 46);
            label7.TabIndex = 9;
            label7.Text = "BISIKLET";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(18, 642);
            label8.Name = "label8";
            label8.Size = new Size(179, 31);
            label8.TabIndex = 10;
            label8.Text = "Toplam Deger =";
            // 
            // satis
            // 
            satis.Anchor = AnchorStyles.None;
            satis.Font = new Font("Segoe UI", 13.8F);
            satis.Location = new Point(512, 371);
            satis.Margin = new Padding(5);
            satis.Name = "satis";
            satis.Size = new Size(211, 68);
            satis.TabIndex = 11;
            satis.Text = "Satış";
            satis.UseVisualStyleBackColor = true;
            satis.Click += satis_Click;
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 804F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(758, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 455F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.Size = new Size(823, 673);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1581, 673);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 13.8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Uygulamasi";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
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
    }
}
