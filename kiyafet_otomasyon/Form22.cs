using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace kiyafet_otomasyon
{
    public partial class Form22 : Form
    {
        public Form1 frm1;
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            frm1.silinmisurunListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Ürün Kodu";
                dataGridView1.Columns[2].HeaderText = "Firma Adı";
                dataGridView1.Columns[3].HeaderText = "Alış fiyatı";
                dataGridView1.Columns[4].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[5].HeaderText = "Kategori";
                dataGridView1.Columns[6].HeaderText = "Silinme Tarihi";
            }
            catch
            {
                ;
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm1.frm7.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //form7 deki textbox1 in textine datagridview1 deki seçili satırın 0. hücresindeki değeri yaz.
            frm1.frm7.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.frm7.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.frm7.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm1.frm7.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm1.frm7.comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm1.frm7.comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm1.frm7.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select urunId,urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori,silinmeTarihi from silinmisurunbil", frm1.bag);
            string alan = "";
            if (comboBox1.Text == "Ürün Adı") alan = "urunAdi";
            else if (comboBox1.Text == "Ürün Kodu") alan = "urunKodu";
            else if (comboBox1.Text == "Firma Adı") alan = "firmaAdi";
            else if (comboBox1.Text == "Alış Fiyatı") alan = "alisFiyati";
            else if (comboBox1.Text == "Satış Fiyatı") alan = "satisFiyati";
            else if (comboBox1.Text == "Kategori") alan = "kategori";
            else if (comboBox1.Text == "Silinme Tarihi") alan = "silinmeTarihi";

            if (comboBox1.Text == "Tümü")//eğer texbox boş ise
            {
                frm1.bag.Open();
                frm1.tabloUrun.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "select urunId,urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori,silinmeTarihi from silinmisurunbil";//tüm kayıtları seç
                adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloUrun);
                frm1.bag.Close();
            }
            if (alan != "")
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = "select urunId,urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori,silinmeTarihi from silinmisurunbil" + " where(" + alan + " like '%" + textBox1.Text + "%' )";
                frm1.tabloUrun.Clear();
                adtr.Fill(frm1.tabloUrun);
                frm1.bag.Close();
            }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frm1.silinmisurunListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Ürün Kodu";
                dataGridView1.Columns[2].HeaderText = "Firma Adı";
                dataGridView1.Columns[3].HeaderText = "Alış fiyatı";
                dataGridView1.Columns[4].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[5].HeaderText = "Kategori";
            }
            catch
            {
                ;
            }
        }
    }
}
