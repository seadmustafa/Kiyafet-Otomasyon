/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace kiyafet_otomasyon
{
    class veriServis
    {
        //public static SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\data.mdf;Integrated Security=True;User Instance=True");
      //  public static SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|C:\demo|\data.mdf;Integrated Security=True;User Instance=True");
        public static SqlConnection bag = new SqlConnection(@"Data Source=.\EK_2014; Initial Catalog=kiyafet_otomasyon_data ;Integrated Security=yes");
       // public static Form1 frm1;
        public static DataSet goster(string sql) 
        {
            bag.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(sql,bag);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataSet ds = new DataSet();
            da.Fill(ds);
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            bag.Close();
            return ds;
        }
    }
}
 * */
