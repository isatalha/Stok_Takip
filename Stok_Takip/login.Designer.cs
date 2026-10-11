namespace Stok_Takip
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            username = new TextBox();
            sifre = new TextBox();
            giris = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(56, 58, 64);
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 11F);
            username.ForeColor = Color.White;
            username.Location = new Point(100, 165);
            username.Name = "username";
            username.PlaceholderText = "Kullanıcı Adı";
            username.Size = new Size(260, 32);
            username.TabIndex = 0;
            // 
            // sifre
            // 
            sifre.BackColor = Color.FromArgb(56, 58, 64);
            sifre.BorderStyle = BorderStyle.FixedSingle;
            sifre.Font = new Font("Segoe UI", 11F);
            sifre.ForeColor = Color.White;
            sifre.Location = new Point(100, 215);
            sifre.Name = "sifre";
            sifre.PasswordChar = '●';
            sifre.PlaceholderText = "Şifre";
            sifre.Size = new Size(260, 32);
            sifre.TabIndex = 1;
            // 
            // giris
            // 
            giris.BackColor = Color.FromArgb(88, 101, 242);
            giris.Cursor = Cursors.Hand;
            giris.FlatAppearance.BorderSize = 0;
            giris.FlatStyle = FlatStyle.Flat;
            giris.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            giris.ForeColor = Color.White;
            giris.Location = new Point(100, 275);
            giris.Name = "giris";
            giris.Size = new Size(260, 44);
            giris.TabIndex = 2;
            giris.Text = "Giriş Yap";
            giris.UseVisualStyleBackColor = false;
            giris.Click += giris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 53);
            label1.Name = "label1";
            label1.Size = new Size(230, 74);
            label1.TabIndex = 3;
            label1.Text = "Birdemir Bisiklet\r\nKullanıcı Girişi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AcceptButton = giris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(460, 380);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(sifre);
            Controls.Add(giris);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox sifre;
        private Button giris;
        private Label label1;
        private PictureBox pictureBox1;
    }
}