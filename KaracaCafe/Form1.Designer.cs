namespace KaracaCafe
{
    partial class FormGiris
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
            this.components = new System.ComponentModel.Container();
            this.button1yönetici = new System.Windows.Forms.Button();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label1Kullanıcı = new System.Windows.Forms.Label();
            this.label2Sifre = new System.Windows.Forms.Label();
            this.button1müşteri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2yönetici = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1yönetici
            // 
            this.button1yönetici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1yönetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1yönetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1yönetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1yönetici.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1yönetici.Location = new System.Drawing.Point(237, 326);
            this.button1yönetici.Name = "button1yönetici";
            this.button1yönetici.Size = new System.Drawing.Size(109, 34);
            this.button1yönetici.TabIndex = 0;
            this.button1yönetici.Text = "GİRİŞ";
            this.button1yönetici.UseVisualStyleBackColor = false;
            this.button1yönetici.Click += new System.EventHandler(this.button1Giris_Click);
            // 
            // textSifre
            // 
            this.textSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSifre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Location = new System.Drawing.Point(198, 283);
            this.textSifre.Name = "textSifre";
            this.textSifre.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(193, 24);
            this.textSifre.TabIndex = 2;
            // 
            // label1Kullanıcı
            // 
            this.label1Kullanıcı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1Kullanıcı.AutoSize = true;
            this.label1Kullanıcı.BackColor = System.Drawing.Color.Transparent;
            this.label1Kullanıcı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1Kullanıcı.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Kullanıcı.Location = new System.Drawing.Point(23, 229);
            this.label1Kullanıcı.Name = "label1Kullanıcı";
            this.label1Kullanıcı.Size = new System.Drawing.Size(142, 26);
            this.label1Kullanıcı.TabIndex = 4;
            this.label1Kullanıcı.Text = "KULLANICI ADI";
            // 
            // label2Sifre
            // 
            this.label2Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2Sifre.AutoSize = true;
            this.label2Sifre.BackColor = System.Drawing.Color.Transparent;
            this.label2Sifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2Sifre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2Sifre.Location = new System.Drawing.Point(94, 281);
            this.label2Sifre.Name = "label2Sifre";
            this.label2Sifre.Size = new System.Drawing.Size(60, 26);
            this.label2Sifre.TabIndex = 5;
            this.label2Sifre.Text = "ŞİFRE";
            // 
            // button1müşteri
            // 
            this.button1müşteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1müşteri.BackColor = System.Drawing.Color.Green;
            this.button1müşteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1müşteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1müşteri.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1müşteri.Location = new System.Drawing.Point(567, 221);
            this.button1müşteri.Name = "button1müşteri";
            this.button1müşteri.Size = new System.Drawing.Size(110, 34);
            this.button1müşteri.TabIndex = 7;
            this.button1müşteri.Text = "GİRİŞ";
            this.button1müşteri.UseVisualStyleBackColor = false;
            this.button1müşteri.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(522, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "MÜŞTERİ GİRİŞ SİSTEMİ";
            // 
            // label2yönetici
            // 
            this.label2yönetici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2yönetici.AutoSize = true;
            this.label2yönetici.BackColor = System.Drawing.Color.Transparent;
            this.label2yönetici.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2yönetici.Location = new System.Drawing.Point(193, 169);
            this.label2yönetici.Name = "label2yönetici";
            this.label2yönetici.Size = new System.Drawing.Size(220, 26);
            this.label2yönetici.TabIndex = 9;
            this.label2yönetici.Text = "YÖNETİCİ GİRİŞ SİSTEMİ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "KARACA YAZILIM BİLİŞİM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 275;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KaracaCafe.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2yönetici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1müşteri);
            this.Controls.Add(this.label2Sifre);
            this.Controls.Add(this.label1Kullanıcı);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.button1yönetici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girisi";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1yönetici;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label1Kullanıcı;
        private System.Windows.Forms.Label label2Sifre;
        private System.Windows.Forms.Button button1müşteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2yönetici;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

