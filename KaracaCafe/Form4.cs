using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaracaCafe
{
    public partial class Form4SİPARİŞ : Form
    {
       
        public Form4SİPARİŞ()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        public void görüntüle()
        {
            listView1.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText=("Select * From menü");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        void adetislem(object sender, EventArgs e) //burada sipariş için adet sayısı girimini sağlıyoruz
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case"button1":
                    textBox1hesapadet.Text += (1).ToString();
                    break;
                case "button2":
                    textBox1hesapadet.Text += (2).ToString();
                    break;
                case "button3":
                    textBox1hesapadet.Text += (3).ToString();
                    break;
                case "button4":
                    textBox1hesapadet.Text += (4).ToString();
                    break;
                case "button5":
                    textBox1hesapadet.Text += (5).ToString();
                    break;
                case "button6":
                    textBox1hesapadet.Text += (6).ToString();
                    break;
                case "button7":
                    textBox1hesapadet.Text += (7).ToString();
                    break;
                case "button8":
                    textBox1hesapadet.Text += (8).ToString();
                    break;
                case "button9":
                    textBox1hesapadet.Text += (9).ToString();
                    break;
                case "button11":
                    textBox1hesapadet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Hatalı Rakam Girdiniz...");
                    break;
            }
        }
        
        private void Form4SİPARİŞ_Load(object sender, EventArgs e)
        {
           
            button4.Click += new EventHandler(adetislem);
            button5.Click += new EventHandler(adetislem);
            button3.Click += new EventHandler(adetislem);
            button1.Click += new EventHandler(adetislem);
            button2.Click += new EventHandler(adetislem);
            button6.Click += new EventHandler(adetislem);
            button7.Click += new EventHandler(adetislem);
            button9.Click += new EventHandler(adetislem);
            button8.Click += new EventHandler(adetislem);
            button11.Click += new EventHandler(adetislem);
        }
        private void button1anamenü_Click_1(object sender, EventArgs e)
        {
            görüntüle();

        }
        OleDbConnection baglantı1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
       private void icecek()
        {
            listView1.Items.Clear();
            baglantı1.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı1;
            komut.CommandText = ("Select * From icecekler");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı1.Close();
        }
        private void button2içecekler_Click_1(object sender, EventArgs e)
        {
            icecek();
        }
        OleDbConnection baglantı3 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
       private void tatlı()
        {
            listView1.Items.Clear();
            baglantı3.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı3;
            komut.CommandText = ("Select * From tatlı");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı3.Close();
        }
        private void button3tatlı_Click_1(object sender, EventArgs e)
        {
            tatlı();
        }
        OleDbConnection baglantı4 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        private void salata()
        {
            listView1.Items.Clear();
            baglantı4.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı4;
            komut.CommandText = ("Select * From salata");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı4.Close();
        }
        private void button4salata_Click_1(object sender, EventArgs e)
        {
            salata();
        }
        OleDbConnection baglantı5 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        private void fastfood()
        {
            listView1.Items.Clear();
            baglantı5.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı5;
            komut.CommandText = ("Select * From fastfood");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı5.Close();
        }
        private void button5fastfood_Click(object sender, EventArgs e)
        {
            fastfood();
        }
        OleDbConnection baglantı6 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        private void arasıcak()
        {
            listView1.Items.Clear();
            baglantı6.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı6;
            komut.CommandText = ("Select * From arasıcak");

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı6.Close();
        }
        private void button6arasıcak_Click_1(object sender, EventArgs e)
        {
            arasıcak();
        }

        public void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (textBox1hesapadet.Text == "")
            {
                textBox1hesapadet.Text = "1";
            }
            if (listView1.Items.Count >= 0)
            {
                int sayac = listView2.Items.Count;
               
                listView2.Items.Add(listView1.SelectedItems[0].SubItems[1].Text);
                listView2.Items[sayac].SubItems.Add(button13masadı.Text);
                listView2.Items[sayac].SubItems.Add(textBox1hesapadet.Text);
                listView2.Items[sayac].SubItems.Add((Convert.ToDouble(listView1.SelectedItems[0].SubItems[2].Text) * Convert.ToDouble(textBox1hesapadet.Text)).ToString());
                listView2.Items[sayac].SubItems.Add("1");
            }
        }

        OleDbConnection veri = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\satıs.mdb");
        OleDbCommand kmt = new OleDbCommand();         //burada siparislerimiz veritabanına aktarma işlemi yaptık
        private void button14siparis_Click(object sender, EventArgs e)
        {
            SİPARİSÖDEME frm = new SİPARİSÖDEME();
           
            for (int i = 0; i < listView2.Items.Count; i++)     // burada siparişlerimizi aktarma işlemini yapıyoruz
                {
                    frm.listView1siparis.Items.Add(new ListViewItem(new String[] { listView2.Items[i].SubItems[1].Text, listView2.Items[i].SubItems[0].Text, listView2.Items[i].SubItems[2].Text, listView2.Items[i].SubItems[3].Text }));       // yeni bir item olusturduk
                    veri.Open();
                    kmt = new OleDbCommand("insert into siparis(masano,ürünad,ürünadet,ürünfiyat) values ('" + frm.listView1siparis.Items[i].SubItems[0].Text + "','" + frm.listView1siparis.Items[i].SubItems[1].Text + "','" + frm.listView1siparis.Items[i].SubItems[2].Text + "','" + listView2.Items[i].SubItems[3].Text + "')", veri);
                    kmt.ExecuteNonQuery();
                    veri.Close();
            }
            this.Close();
            frm.Show();
        }
        private void listView2_DoubleClick(object sender, EventArgs e)      // sipariste silme işlemi yapıyoruz
        {
            {
                if (listView2.SelectedIndices.Count > 0)        //Secili satır varmı yokmu kontrol ediyoruz
                   
                    listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);         //Seçili satırın index i ni yakalayarak satırı sildik.
            }
        }
        private void button12geridönüs_Click(object sender, EventArgs e)
        {
            Form3Masa frm = new Form3Masa();
            this.Close();
            frm.Show();
        }

        private void button10cıkış_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çikmak İstediginizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1hesapadet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10temizle_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }    
  }