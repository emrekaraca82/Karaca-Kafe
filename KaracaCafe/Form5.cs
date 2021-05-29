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
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        OleDbCommand komut = new OleDbCommand();
        public void görüntüle()               // ekleme işlemini bu kısmında yaptık
        {
            listView1.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = ("Select * From menü");

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
        private void button2sil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "delete from menü where ürünad='" + textBox3.Text + "'";
            komut.ExecuteNonQuery();
            baglantı.Close();
            görüntüle();
        }
        private void button6güncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "update menü set ürünad='" + textBox1.Text + "',fiyat='" + textBox2.Text + "'where ürünad='" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglantı.Close();
            görüntüle();
        }
        private void button3kaydet_Click(object sender, EventArgs e)
        {

            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into menü(ürünad,fiyat) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            görüntüle();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            {
                if (listView1.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); //Seçili satırın index i ni yakalayarak satırı sildik.
            }
        }
        public void button1anamenü_Click(object sender, EventArgs e)
        {
            görüntüle();

        }
        OleDbConnection baglantı1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
          OleDbCommand komut1 = new OleDbCommand();

          public void görüntüle1()           // ekleme işlemini bu kısmında yaptık
          {
              listView1.Items.Clear();
              baglantı1.Open();
              OleDbCommand komut1 = new OleDbCommand();
              komut1.Connection = baglantı1;
              komut1.CommandText = ("Select * From fastfood");

              OleDbDataReader oku = komut1.ExecuteReader();
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
          
        private void button5fastfood_Click(object sender, EventArgs e)
        {
            görüntüle1();
         
        }
        OleDbConnection baglantı2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        OleDbCommand komut2 = new OleDbCommand();

        public void görüntüle2()           // ekleme işlemini bu kısmında yaptık
        {
            listView1.Items.Clear();
            baglantı2.Open();
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglantı2;
            komut2.CommandText = ("Select * From arasıcak");

            OleDbDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["ürünad"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı2.Close();
        }
        private void button6arasıcak_Click(object sender, EventArgs e)
        {
            görüntüle2();
        }
        OleDbConnection baglantı3 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        OleDbCommand komut3 = new OleDbCommand();

        public void görüntüle3()           // ekleme işlemini bu kısmında yaptık
        {
            listView1.Items.Clear();
            baglantı3.Open();
            OleDbCommand komut3 = new OleDbCommand();
            komut3.Connection = baglantı3;
            komut3.CommandText = ("Select * From salata");

            OleDbDataReader oku = komut3.ExecuteReader();
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
        private void button4salata_Click(object sender, EventArgs e)
        {
            görüntüle3();
        }
        OleDbConnection baglantı4 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        OleDbCommand komut4 = new OleDbCommand();

        public void görüntüle4()           // ekleme işlemini bu kısmında yaptık
        {
            listView1.Items.Clear();
            baglantı4.Open();
            OleDbCommand komut4 = new OleDbCommand();
            komut4.Connection = baglantı4;
            komut4.CommandText = ("Select * From icecekler");

            OleDbDataReader oku = komut4.ExecuteReader();
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
        private void button2içecekler_Click(object sender, EventArgs e)
        {
            görüntüle4();
        }
        OleDbConnection baglantı5 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\Mutfak.mdb");
        OleDbCommand komut5 = new OleDbCommand();

        public void görüntüle5()           // ekleme işlemini bu kısmında yaptık
        {
            listView1.Items.Clear();
            baglantı5.Open();
            OleDbCommand komut5 = new OleDbCommand();
            komut5.Connection = baglantı5;
            komut5.CommandText = ("Select * From tatlı");

            OleDbDataReader oku = komut5.ExecuteReader();
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
        private void button3tatlı_Click(object sender, EventArgs e)
        {
            görüntüle5();
        }
        private void button5geri_Click(object sender, EventArgs e)
        {
            Form2Anaekran frm = new Form2Anaekran();
            this.Close();
            frm.Show();
        }
        private void button4Cıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çikmak İstediginizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}