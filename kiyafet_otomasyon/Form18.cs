using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // bunu hepsine eklemeliyiz sql bağlantısı için
using Microsoft.Office.Interop.Excel;

namespace kiyafet_otomasyon
{
    public partial class Form18 : Form
    {
        public Form1 frm1;
        public Form18()
        {
            InitializeComponent();
        }


        public void gununSatisListele()
        {
            frm1.tabloSatis.Clear();
            frm1.bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select faturaNo,musteriAdi,musteriSoyadi,tcKimlik,urunAdi,satisFiyat,adet,toplamTutar,kasaNo,tarih from satisbil Where tarih = '" + dateTimePicker1.Text + "'", frm1.bag);
            //tarih alanı dateTimePicker1 seçili tarih olan kayıtları seç
            adtr.Fill(frm1.tabloSatis);// tabloSatis sanal tablosunu adaptördeki veri ile doldur.
            dataGridView1.DataSource = frm1.tabloSatis;//dataGridView1'in veri kaynağı tabloSatis
            dataGridView1.DataSource = frm1.tabloSatis;
            frm1.bag.Close();
        }

        private void Form18_Load_1(object sender, EventArgs e)
        {
            gununSatisListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview1 seçme modunu satırı komple satır seç olarak ayarla               
                dataGridView1.Columns[0].HeaderText = "Fatura No";
                //datagridview1 in 0. sütun başlık metni Fatura No olsun
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns[3].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[4].HeaderText = "Ürün Adı";
                dataGridView1.Columns[5].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[6].HeaderText = "Adet";
                dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
                dataGridView1.Columns[8].HeaderText = "Kasa No";
                dataGridView1.Columns[9].HeaderText = "Tarih";
            }
            catch
            {
                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            gununSatisListele(); 
        }

        private void button1_Click(object sender, EventArgs e) //EXEL AKTAR
        {

            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, i + 1];//satır sütun şeklindendir.
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[j + 2, i + 1];//satır sütun şeklindendir.
                    myRange.Value2 = dataGridView1[i, j].Value;// kolom satır şeklindedir
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //KAPAT
        {
            Close();
        }




    }
}
