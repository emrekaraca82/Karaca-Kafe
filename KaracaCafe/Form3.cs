using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaracaCafe
{
    public partial class Form3Masa : Form
    {
        Form4SİPARİŞ frm = new Form4SİPARİŞ();
        public Form3Masa()
        {
            InitializeComponent();
        }
        public string buttonValue;
        public string buttonName;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            int uzunluk = button1.Text.Length;
            buttonValue = button1.Text.Substring(uzunluk-6,6);
            buttonName = button1.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            int uzunluk = button2.Text.Length;
            buttonValue = button2.Text.Substring(uzunluk - 6, 6);
            buttonName = button2.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            int uzunluk = button3.Text.Length;
            buttonValue = button3.Text.Substring(uzunluk - 6, 6);
            buttonName = button3.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            int uzunluk = button4.Text.Length;
            buttonValue = button4.Text.Substring(uzunluk - 6, 6);
            buttonName = button4.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            int uzunluk = button5.Text.Length;
            buttonValue = button5.Text.Substring(uzunluk - 6, 6);
            buttonName = button5.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            int uzunluk = button6.Text.Length;
            buttonValue = button6.Text.Substring(uzunluk - 6, 6);
            buttonName = button6.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            int uzunluk = button7.Text.Length;
            buttonValue = button7.Text.Substring(uzunluk - 6, 6);
            buttonName = button7.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            int uzunluk = button8.Text.Length;
            buttonValue = button8.Text.Substring(uzunluk - 6, 6);
            buttonName = button8.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            int uzunluk = button9.Text.Length;
            buttonValue = button9.Text.Substring(uzunluk - 6, 6);
            buttonName = button9.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            int uzunluk = button10.Text.Length;
            buttonValue = button10.Text.Substring(uzunluk - 7, 7);
            buttonName = button10.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            int uzunluk = button11.Text.Length;
            buttonValue = button11.Text.Substring(uzunluk - 7, 7);
            buttonName = button11.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;
            int uzunluk = button12.Text.Length;
            buttonValue = button12.Text.Substring(uzunluk - 7, 7);
            buttonName = button12.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Red;
            int uzunluk = button13.Text.Length;
            buttonValue = button13.Text.Substring(uzunluk - 7, 7);
            buttonName = button13.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Red;
            int uzunluk = button14.Text.Length;
            buttonValue = button14.Text.Substring(uzunluk - 7, 7);
            buttonName = button14.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Red;
            int uzunluk = button15.Text.Length;
            buttonValue = button15.Text.Substring(uzunluk - 7, 7);
            buttonName = button15.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Red;
            int uzunluk = button16.Text.Length;
            buttonValue = button16.Text.Substring(uzunluk - 7, 7);
            buttonName = button16.Name;
            frm.button13masadı.Text = buttonValue;
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormGiris frm = new FormGiris(); // geri dönüş yapıyoruz
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
    }
}
