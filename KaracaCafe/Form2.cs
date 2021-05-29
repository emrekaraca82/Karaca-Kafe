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
    public partial class Form2Anaekran : Form
    {
       
        
        public Form2Anaekran()
        {
            InitializeComponent();
        }
        private void Form2Anaekran_Load(object sender, EventArgs e)
        {

        }

        private void button1masalar_Click(object sender, EventArgs e)
        {
            Form3Masa frm = new Form3Masa();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mutfak frmb = new Mutfak();
            frmb.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 frma = new Form7();
            frma.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8kasa frm = new Form8kasa();
            this.Close();
            frm.Show();
        }
        private void button5geri_Click(object sender, EventArgs e)
        {
            FormGiris frm = new FormGiris();
            this.Close();
            frm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çikmak İstediginizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

    }
}
