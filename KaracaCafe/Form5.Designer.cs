namespace KaracaCafe
{
    partial class Mutfak
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
            this.button3kaydet = new System.Windows.Forms.Button();
            this.button4Cıkıs = new System.Windows.Forms.Button();
            this.button5geri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button6ad = new System.Windows.Forms.Button();
            this.button7fiyat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6güncelle = new System.Windows.Forms.Button();
            this.button9silinecekdeger = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2sil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6arasıcak = new System.Windows.Forms.Button();
            this.button5fastfood = new System.Windows.Forms.Button();
            this.button4salata = new System.Windows.Forms.Button();
            this.button3tatlı = new System.Windows.Forms.Button();
            this.button2içecekler = new System.Windows.Forms.Button();
            this.button1anamenü = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3kaydet
            // 
            this.button3kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3kaydet.Location = new System.Drawing.Point(921, 317);
            this.button3kaydet.Name = "button3kaydet";
            this.button3kaydet.Size = new System.Drawing.Size(96, 35);
            this.button3kaydet.TabIndex = 3;
            this.button3kaydet.Text = "KAYDET";
            this.button3kaydet.UseVisualStyleBackColor = true;
            this.button3kaydet.Click += new System.EventHandler(this.button3kaydet_Click);
            // 
            // button4Cıkıs
            // 
            this.button4Cıkıs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4Cıkıs.BackColor = System.Drawing.Color.Red;
            this.button4Cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4Cıkıs.Location = new System.Drawing.Point(1002, 409);
            this.button4Cıkıs.Name = "button4Cıkıs";
            this.button4Cıkıs.Size = new System.Drawing.Size(115, 42);
            this.button4Cıkıs.TabIndex = 4;
            this.button4Cıkıs.Text = "ÇIKIŞ";
            this.button4Cıkıs.UseVisualStyleBackColor = false;
            this.button4Cıkıs.Click += new System.EventHandler(this.button4Cıkıs_Click);
            // 
            // button5geri
            // 
            this.button5geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5geri.BackColor = System.Drawing.Color.Lime;
            this.button5geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5geri.Location = new System.Drawing.Point(18, 409);
            this.button5geri.Name = "button5geri";
            this.button5geri.Size = new System.Drawing.Size(109, 42);
            this.button5geri.TabIndex = 5;
            this.button5geri.Text = "GERİ";
            this.button5geri.UseVisualStyleBackColor = false;
            this.button5geri.Click += new System.EventHandler(this.button5geri_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(368, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 352);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün No";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Ad";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Fiyat";
            this.columnHeader3.Width = 103;
            // 
            // button6ad
            // 
            this.button6ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6ad.Location = new System.Drawing.Point(768, 52);
            this.button6ad.Name = "button6ad";
            this.button6ad.Size = new System.Drawing.Size(122, 39);
            this.button6ad.TabIndex = 8;
            this.button6ad.Text = "ÜRÜN AD";
            this.button6ad.UseVisualStyleBackColor = true;
            // 
            // button7fiyat
            // 
            this.button7fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7fiyat.Location = new System.Drawing.Point(768, 139);
            this.button7fiyat.Name = "button7fiyat";
            this.button7fiyat.Size = new System.Drawing.Size(122, 41);
            this.button7fiyat.TabIndex = 9;
            this.button7fiyat.Text = "ÜRÜN FİYAT";
            this.button7fiyat.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(921, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 39);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(921, 139);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 41);
            this.textBox2.TabIndex = 11;
            // 
            // button6güncelle
            // 
            this.button6güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6güncelle.Location = new System.Drawing.Point(768, 317);
            this.button6güncelle.Name = "button6güncelle";
            this.button6güncelle.Size = new System.Drawing.Size(122, 35);
            this.button6güncelle.TabIndex = 14;
            this.button6güncelle.Text = "GÜNCELLE";
            this.button6güncelle.UseVisualStyleBackColor = true;
            this.button6güncelle.Click += new System.EventHandler(this.button6güncelle_Click);
            // 
            // button9silinecekdeger
            // 
            this.button9silinecekdeger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9silinecekdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9silinecekdeger.Location = new System.Drawing.Point(768, 226);
            this.button9silinecekdeger.Name = "button9silinecekdeger";
            this.button9silinecekdeger.Size = new System.Drawing.Size(122, 39);
            this.button9silinecekdeger.TabIndex = 12;
            this.button9silinecekdeger.Text = "SİLİNECEK KISIM";
            this.button9silinecekdeger.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(921, 224);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 41);
            this.textBox3.TabIndex = 13;
            // 
            // button2sil
            // 
            this.button2sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2sil.Location = new System.Drawing.Point(1038, 317);
            this.button2sil.Name = "button2sil";
            this.button2sil.Size = new System.Drawing.Size(79, 35);
            this.button2sil.TabIndex = 2;
            this.button2sil.Text = "SİL";
            this.button2sil.UseVisualStyleBackColor = true;
            this.button2sil.Click += new System.EventHandler(this.button2sil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button6arasıcak);
            this.groupBox1.Controls.Add(this.button5fastfood);
            this.groupBox1.Controls.Add(this.button4salata);
            this.groupBox1.Controls.Add(this.button3tatlı);
            this.groupBox1.Controls.Add(this.button2içecekler);
            this.groupBox1.Controls.Add(this.button1anamenü);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 364);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // button6arasıcak
            // 
            this.button6arasıcak.BackColor = System.Drawing.Color.Red;
            this.button6arasıcak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6arasıcak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6arasıcak.Location = new System.Drawing.Point(6, 172);
            this.button6arasıcak.Name = "button6arasıcak";
            this.button6arasıcak.Size = new System.Drawing.Size(134, 54);
            this.button6arasıcak.TabIndex = 5;
            this.button6arasıcak.Text = "ARA SICAK";
            this.button6arasıcak.UseVisualStyleBackColor = false;
            this.button6arasıcak.Click += new System.EventHandler(this.button6arasıcak_Click);
            // 
            // button5fastfood
            // 
            this.button5fastfood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5fastfood.BackColor = System.Drawing.Color.Blue;
            this.button5fastfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5fastfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5fastfood.Location = new System.Drawing.Point(189, 52);
            this.button5fastfood.Name = "button5fastfood";
            this.button5fastfood.Size = new System.Drawing.Size(149, 53);
            this.button5fastfood.TabIndex = 4;
            this.button5fastfood.Text = "FASTFOOD";
            this.button5fastfood.UseVisualStyleBackColor = false;
            this.button5fastfood.Click += new System.EventHandler(this.button5fastfood_Click);
            // 
            // button4salata
            // 
            this.button4salata.BackColor = System.Drawing.Color.Blue;
            this.button4salata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4salata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4salata.Location = new System.Drawing.Point(189, 172);
            this.button4salata.Name = "button4salata";
            this.button4salata.Size = new System.Drawing.Size(149, 54);
            this.button4salata.TabIndex = 3;
            this.button4salata.Text = "SALATA";
            this.button4salata.UseVisualStyleBackColor = false;
            this.button4salata.Click += new System.EventHandler(this.button4salata_Click);
            // 
            // button3tatlı
            // 
            this.button3tatlı.BackColor = System.Drawing.Color.Blue;
            this.button3tatlı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3tatlı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3tatlı.Location = new System.Drawing.Point(189, 284);
            this.button3tatlı.Name = "button3tatlı";
            this.button3tatlı.Size = new System.Drawing.Size(149, 52);
            this.button3tatlı.TabIndex = 2;
            this.button3tatlı.Text = "TATLI";
            this.button3tatlı.UseVisualStyleBackColor = false;
            this.button3tatlı.Click += new System.EventHandler(this.button3tatlı_Click);
            // 
            // button2içecekler
            // 
            this.button2içecekler.BackColor = System.Drawing.Color.Red;
            this.button2içecekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2içecekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2içecekler.Location = new System.Drawing.Point(6, 284);
            this.button2içecekler.Name = "button2içecekler";
            this.button2içecekler.Size = new System.Drawing.Size(134, 52);
            this.button2içecekler.TabIndex = 1;
            this.button2içecekler.Text = "İÇECEKLER";
            this.button2içecekler.UseVisualStyleBackColor = false;
            this.button2içecekler.Click += new System.EventHandler(this.button2içecekler_Click);
            // 
            // button1anamenü
            // 
            this.button1anamenü.BackColor = System.Drawing.Color.Red;
            this.button1anamenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1anamenü.Location = new System.Drawing.Point(6, 52);
            this.button1anamenü.Name = "button1anamenü";
            this.button1anamenü.Size = new System.Drawing.Size(134, 53);
            this.button1anamenü.TabIndex = 0;
            this.button1anamenü.Text = "ANA MENÜ";
            this.button1anamenü.UseVisualStyleBackColor = false;
            this.button1anamenü.Click += new System.EventHandler(this.button1anamenü_Click);
            // 
            // Mutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KaracaCafe.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(1127, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6güncelle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button9silinecekdeger);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7fiyat);
            this.Controls.Add(this.button6ad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5geri);
            this.Controls.Add(this.button4Cıkıs);
            this.Controls.Add(this.button3kaydet);
            this.Controls.Add(this.button2sil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Mutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUTFAK";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3kaydet;
        private System.Windows.Forms.Button button4Cıkıs;
        private System.Windows.Forms.Button button5geri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button6ad;
        private System.Windows.Forms.Button button7fiyat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6güncelle;
        private System.Windows.Forms.Button button9silinecekdeger;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2sil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6arasıcak;
        private System.Windows.Forms.Button button5fastfood;
        private System.Windows.Forms.Button button4salata;
        private System.Windows.Forms.Button button3tatlı;
        private System.Windows.Forms.Button button2içecekler;
        private System.Windows.Forms.Button button1anamenü;
    }
}