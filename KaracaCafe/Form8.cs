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
    public partial class Form8kasa : Form
    {
        public Form8kasa()
        {
            InitializeComponent();
        }
        OleDbConnection kasa = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\hesap özeti.mdb");
        DataTable tablo = new DataTable();
        public void kasaraporlama()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From hesap", kasa);
            adtr.Fill(tablo);
            CrystalReport2 cry = new CrystalReport2();
            cry.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = cry;
        }
       
        private void Form8kasa_Load(object sender, EventArgs e)
        {
            kasaraporlama();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From hesap Where masano='" + textBox1.Text + "'", kasa);
            adtr.Fill(tablo);
            CrystalReport2 cry = new CrystalReport2();
            cry.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = cry;

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
