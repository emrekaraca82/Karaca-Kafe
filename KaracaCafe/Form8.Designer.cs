namespace KaracaCafe
{
    partial class Form8kasa
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button5geri = new System.Windows.Forms.Button();
            this.button4Cıkıs = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(146, -3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(791, 507);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // button5geri
            // 
            this.button5geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5geri.BackColor = System.Drawing.Color.Lime;
            this.button5geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5geri.Location = new System.Drawing.Point(12, 21);
            this.button5geri.Name = "button5geri";
            this.button5geri.Size = new System.Drawing.Size(110, 33);
            this.button5geri.TabIndex = 7;
            this.button5geri.Text = "GERİ";
            this.button5geri.UseVisualStyleBackColor = false;
            this.button5geri.Click += new System.EventHandler(this.button5geri_Click);
            // 
            // button4Cıkıs
            // 
            this.button4Cıkıs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4Cıkıs.BackColor = System.Drawing.Color.Red;
            this.button4Cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4Cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4Cıkıs.Location = new System.Drawing.Point(12, 454);
            this.button4Cıkıs.Name = "button4Cıkıs";
            this.button4Cıkıs.Size = new System.Drawing.Size(110, 38);
            this.button4Cıkıs.TabIndex = 8;
            this.button4Cıkıs.Text = "ÇIKIŞ";
            this.button4Cıkıs.UseVisualStyleBackColor = false;
            this.button4Cıkıs.Click += new System.EventHandler(this.button4Cıkıs_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(23, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "SORGULA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KaracaCafe.Properties.Resources.images__6_4;
            this.ClientSize = new System.Drawing.Size(936, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4Cıkıs);
            this.Controls.Add(this.button5geri);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form8kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8kasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button5geri;
        private System.Windows.Forms.Button button4Cıkıs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

    }
}