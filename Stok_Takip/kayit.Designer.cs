namespace Stok_Takip
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            label1 = new Label();
            kayitUsername = new TextBox();
            kayitPassword = new TextBox();
            kayitAccess = new ComboBox();
            kayitEt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Kayıt";
            // 
            // kayitUsername
            // 
            kayitUsername.BackColor = Color.FromArgb(56, 58, 64);
            kayitUsername.BorderStyle = BorderStyle.FixedSingle;
            kayitUsername.Font = new Font("Segoe UI", 11F);
            kayitUsername.ForeColor = Color.White;
            kayitUsername.Location = new Point(50, 95);
            kayitUsername.Name = "kayitUsername";
            kayitUsername.PlaceholderText = "Kullanıcı Adı";
            kayitUsername.Size = new Size(240, 32);
            kayitUsername.TabIndex = 1;
            // 
            // kayitPassword
            // 
            kayitPassword.BackColor = Color.FromArgb(56, 58, 64);
            kayitPassword.BorderStyle = BorderStyle.FixedSingle;
            kayitPassword.Font = new Font("Segoe UI", 11F);
            kayitPassword.ForeColor = Color.White;
            kayitPassword.Location = new Point(50, 142);
            kayitPassword.Name = "kayitPassword";
            kayitPassword.PasswordChar = '●';
            kayitPassword.PlaceholderText = "Şifre";
            kayitPassword.Size = new Size(240, 32);
            kayitPassword.TabIndex = 2;
            // 
            // kayitAccess
            // 
            kayitAccess.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kayitAccess.AutoCompleteSource = AutoCompleteSource.ListItems;
            kayitAccess.BackColor = Color.FromArgb(56, 58, 64);
            kayitAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            kayitAccess.FlatStyle = FlatStyle.Flat;
            kayitAccess.Font = new Font("Segoe UI", 11F);
            kayitAccess.ForeColor = Color.White;
            kayitAccess.FormattingEnabled = true;
            kayitAccess.Items.AddRange(new object[] { "Yönetici", "Personel", "Misafir" });
            kayitAccess.Location = new Point(50, 189);
            kayitAccess.Name = "kayitAccess";
            kayitAccess.Size = new Size(240, 33);
            kayitAccess.TabIndex = 3;
            // 
            // kayitEt
            // 
            kayitEt.BackColor = Color.FromArgb(35, 165, 90);
            kayitEt.Cursor = Cursors.Hand;
            kayitEt.FlatAppearance.BorderSize = 0;
            kayitEt.FlatStyle = FlatStyle.Flat;
            kayitEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kayitEt.ForeColor = Color.White;
            kayitEt.Location = new Point(50, 246);
            kayitEt.Name = "kayitEt";
            kayitEt.Size = new Size(240, 44);
            kayitEt.TabIndex = 4;
            kayitEt.Text = "Kayıt Et";
            kayitEt.UseVisualStyleBackColor = false;
            kayitEt.Click += kayitEt_Click;
            // 
            // kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(340, 335);
            Controls.Add(label1);
            Controls.Add(kayitUsername);
            Controls.Add(kayitPassword);
            Controls.Add(kayitAccess);
            Controls.Add(kayitEt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt";
            Load += kayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kayitUsername;
        private TextBox kayitPassword;
        private ComboBox kayitAccess;
        private Button kayitEt;
    }
}