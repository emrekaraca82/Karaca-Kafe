using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;

namespace KaracaCafe
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection rapor = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\DAMLA REİS\\Documents\\satıs.mdb");
        DataTable tablo = new DataTable();
        public void raporlama()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From siparis", rapor);
            adtr.Fill(tablo);
            CrystalReport1 cry = new CrystalReport1();
            cry.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = cry;
        }
       
        private void Form7_Load(object sender, EventArgs e)
        {
            raporlama();
        }
        private void button1_Click(object sender, EventArgs e)          //masa no göre raporlama
        {
            tablo.Clear(); 
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From siparis Where masano='"+textBox1.Text+"'", rapor);
            adtr.Fill(tablo);
            CrystalReport1 cry = new CrystalReport1();
            cry.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = cry;
        }
        private void button2_Click(object sender, EventArgs e)          //ürün adına göre raporlama
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From siparis Where ürünad='" + textBox2.Text + "'", rapor);
            adtr.Fill(tablo);
            CrystalReport1 cry = new CrystalReport1();
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
