using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaracaCafe
{
    public partial class SİPARİSÖDEME : Form
    {

        public SİPARİSÖDEME()
        {
            InitializeComponent();
        }
        public void SİPARİSÖDEME_Load(object sender, EventArgs e)
        {
            Form4SİPARİŞ frm = new Form4SİPARİŞ();
            textBox1indirimtutarı.TextChanged += new EventHandler(textBox1indirimtutarı_TextChanged);
            if (listView1siparis.Items.Count > 0)
            {
                decimal toplam = 0;
                for (int i = 0; i < listView1siparis.Items.Count; i++)
                {
                    toplam += Convert.ToDecimal(listView1siparis.Items[i].SubItems[3].Text);
                }
                textBox3.Text = string.Format("{0:0.00}", toplam);
                textBox4.Text = string.Format("{0:0.00}", toplam);
            }
            textBox1indirimtutarı.Clear();
        }

        private void textBox1indirimtutarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(textBox1indirimtutarı.Text) < Convert.ToDecimal(textBox3.Text))
                {
                    try
                    {
                        textBox1.Text = string.Format("{0:0.00}", Convert.ToDecimal(textBox1indirimtutarı.Text));
                    }

                    catch (Exception)
                    {
                        textBox1.Text = string.Format("{0:0.00}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarını Fiyatdan Fazla Olamaz...");
                }
            }
            catch (Exception)
            {
                textBox1.Text = string.Format("{0:0.00}", 0);
            }
        }

        private void checkBox1indirimuygula_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1indirimuygula.Checked)
            {
                textBox1indirimtutarı.Visible = true;
            }
            else
            {
                textBox1indirimtutarı.Visible = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) > 0)
            {
                decimal ödeme = 0;
                textBox4.Text = textBox3.Text;
                ödeme = Convert.ToDecimal(textBox4.Text) - Convert.ToDecimal(textBox1.Text);
                textBox4.Text = string.Format("{0:0.00}", ödeme);
            }
            else
            {
                textBox4.Text = textBox3.Text;
            }
            decimal kdv = Convert.ToDecimal(textBox4.Text) * 18 / 100;
            textBox2.Text = string.Format("{0:0.00}", kdv);

        }
        private void button4hesapkapat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesabınız Kapatılıyor...");
            MessageBox.Show("Hesabınız Kapatılmıştır İyi Günler...");
            Form3Masa frm = new Form3Masa();
            this.Close();
            frm.Show();
        }
      
        Form4SİPARİŞ frm = new Form4SİPARİŞ();
        public void button3hesapözeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        OleDbConnection veri = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\hesap özeti.mdb");
        OleDbCommand kmt = new OleDbCommand();
       private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslık = new Font("Calibri", 26, FontStyle.Bold);
            Font altbaslık = new Font("Calibri", 22, FontStyle.Bold);
            Font icerik = new Font("Calibri", 18, FontStyle.Bold);
            SolidBrush ym = new SolidBrush(Color.Black);

            StringFormat yn = new StringFormat();
            yn.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("HESAP ÖZETİ", baslık, ym, 300, 100, yn);
            e.Graphics.DrawString("Masa No      Ürün Adı       Ürün Adet        Ürün Fiyatı", altbaslık, ym, 150, 250, yn);
            e.Graphics.DrawString("------------------------------------------------------------------------", altbaslık, ym, 150, 280, yn);
           for (int i = 0; i < listView1siparis.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1siparis.Items[i].SubItems[0].Text, icerik, ym, 150, 300 + i * 30, yn);
                e.Graphics.DrawString(listView1siparis.Items[i].SubItems[1].Text, icerik, ym, 305, 300 + i * 30, yn);
                e.Graphics.DrawString(listView1siparis.Items[i].SubItems[2].Text, icerik, ym, 510, 300 + i * 30, yn);
                e.Graphics.DrawString(listView1siparis.Items[i].SubItems[3].Text, icerik, ym, 700, 300 + i * 30, yn);
            }
            veri.Open();
            e.Graphics.DrawString("------------------------------------------------------------------------", altbaslık, ym, 150, 300 + 30 * listView1siparis.Items.Count, yn);
            e.Graphics.DrawString("MASA NO =" +listView1siparis.Items[0].SubItems[0].Text + "", altbaslık, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 1), yn);
            e.Graphics.DrawString("İNDİRİM TUTARI =" + textBox1.Text + " TL", altbaslık, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 2), yn);
            e.Graphics.DrawString("KDV TUTARI =" + textBox2.Text + " TL", altbaslık, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 3), yn);
            e.Graphics.DrawString("TOPLAM TUTARI =" + textBox3.Text + " TL", altbaslık, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 4), yn);
            e.Graphics.DrawString("ÖDENECEK TUTARI =" + textBox4.Text + " TL", altbaslık, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 5), yn);
            kmt = new OleDbCommand("insert into hesap(masano,indirimtutarı,kdvtutarı,toplamtutar,ödenecektutar) values('"+listView1siparis.Items[0].SubItems[0].Text.ToString()+"','" + textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", veri);
            kmt.ExecuteNonQuery();
            veri.Close();
       }
       private void button1Geridön_Click(object sender, EventArgs e)
       {
           Form4SİPARİŞ frm = new Form4SİPARİŞ();
           this.Close();
           frm.Show();
       }

       private void button2cıkıs_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Çikmak İstediginizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
               Application.Exit();
           }
       }
    }
}