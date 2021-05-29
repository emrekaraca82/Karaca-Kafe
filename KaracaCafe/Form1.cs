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
    public partial class FormGiris : Form
    {
        Form2Anaekran frm = new Form2Anaekran();
        Form3Masa frma = new Form3Masa();
        public FormGiris()
        {
            InitializeComponent();
        }
        private void FormGiris_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Text = " KARACA YAZILIM BİLİŞİM ";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);
        }

        public void giris() // yetkili girişi için metot oluşturduk
        {
            string kullanıcıadı = textBox1.Text;
            string sifre = textSifre.Text;
            if (kullanıcıadı == "emrebaba" && sifre == "1234")
            {
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Sifre Yanlış...");
            }
        }
        private void button1Giris_Click(object sender, EventArgs e)
        {
            giris();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frma.Show();
            this.Hide();
        }

    }
}