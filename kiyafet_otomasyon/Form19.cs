using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kiyafet_otomasyon
{
    public partial class Form19 : Form
    {
        public Form1 frm1;
        public string yetki="false";
        public Form19()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Bos alanlari doldur!!!");
            }

            else
            {
                //  SqlConnection bag = new SqlConnection(@"Data Source=.\EK_2014;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.EK_2014\MSSQL\DATA\data.mdf;Integrated Security=True;User Instance=True");
                SqlConnection bag = new SqlConnection(@"Data Source=.\EK_2014; Initial Catalog=kiyafet_otomasyon_data ;Integrated Security=yes");
                bag.Open();
                //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
                SqlCommand komut = new SqlCommand("select * from kullanıcıbil", bag);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                SqlDataAdapter da = new SqlDataAdapter(komut);
                //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
                DataSet ds = new DataSet();
                da.Fill(ds);
                bag.Close();
                /// kullanıcı adı şifre bulmak
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "SELECT * FROM kullanıcıbil where kullanıcıadi='" + txtKullanici.Text + "' AND sifre='" + txtSifre.Text + "'";
                SqlDataReader oku;
                oku = komut.ExecuteReader();


                if (oku.Read())
                {

                   string yetki = oku["yetki"].ToString();
         //           MessageBox.Show(yetki);
                    
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();

                    if (yetki == "kullanıcı")
                    {
                        // butonları aktif pasif yapıyor
                        Application.OpenForms["Form1"].Controls["groupBox2"].Visible = false;

                    }



                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
                bag.Close();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan çık.
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        
    }
}
