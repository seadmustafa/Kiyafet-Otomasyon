using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Sql ile başlayan işlemleri çalıştırır.
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiyafet_otomasyon
{

    public partial class Form17 : Form
    {
        public Form1 frm1;
        public Form17()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void griddoldur()
        {
            con = new SqlConnection(@"Data Source=.\EK_2014; Initial Catalog=kiyafet_otomasyon_data ;Integrated Security=yes");
            da = new SqlDataAdapter("Select *From kullanıcıbil", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kullanıcıbil");
            dataGridView1.DataSource = ds.Tables["kullanıcıbil"];
            con.Close();
        }



                SqlConnection bag = new SqlConnection(@"Data Source=.\EK_2014; Initial Catalog=kiyafet_otomasyon_data ;Integrated Security=yes");
                DataTable tablo = new DataTable();
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                SqlDataAdapter adptr = new SqlDataAdapter();
                SqlCommand komut = new SqlCommand();
                //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
                DataSet dset = new DataSet();

                void Listele()
                {
                    tablo.Clear();
                    bag.Open();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * from kullanıcıbil",bag);
                    adptr.Fill(tablo);
                    adptr.Dispose();
                    bag.Close();
                    
                }


        private void button2_Click(object sender, KeyPressEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("kullanıcı");

            comboBox1.Items.Add("yönetici");

            griddoldur();

        }

        private void button2_Click(object sender, EventArgs e) // KAYDET
        {

            if (TextBox1.Text == "" && TextBox2.Text == "" && textBox3.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("İlgili Alanları Doldurunuz!");
            }
            else if (TextBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz!");
            }
            else if (TextBox2.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz!");
            }
            else if (TextBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor!");
            }
            else
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into kullanıcıbil(kullanıcıadi,sifre,yetki) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)// SİL
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from kullanıcıbil where kullanıcıadi='" + TextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

    }
}