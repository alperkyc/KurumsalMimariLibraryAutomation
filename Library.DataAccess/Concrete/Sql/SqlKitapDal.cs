using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.DataAccess.Concrete.Sql
{
    public class SqlKitapDal : ISqlKitapDal
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TV2Q316\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");

        public void AddCategory(string categoryName)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("exec KategoriEkle @KitapAdi", con);
            cmd.Parameters.AddWithValue("@KitapAdi", categoryName);
            cmd.ExecuteNonQuery();




        }

        public List<Kitap> KitapList()
        {
            
            con.Open();

            SqlCommand cmd = new SqlCommand("exec KitapListele", con);
            SqlDataReader dr = cmd.ExecuteReader();

           

            List<Kitap> kl = new List<Kitap>();
            while (dr.Read())
            {
                Kitap kitap = new Kitap();
                kitap.Id = Convert.ToInt32(dr["Id"]);
                kitap.KitapAdi = dr["KitapAdi"].ToString();
                kitap.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                kitap.YazarId = Convert.ToInt32(dr["YazarId"]);
                kitap.RafNo = dr["RafNo"].ToString();

                kl.Add(kitap);

            }

            con.Close();

            return kl;
        }

        public List<Kitap> ListKitapByCategory(int id)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("Select *From Kitaps where KategoriId=@ID",con);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Kitap> kitap=new List<Kitap>();
            while (dr.Read())
            {
                Kitap kitaps = new Kitap();
                kitaps.Id = Convert.ToInt32(dr["Id"]);
                kitaps.KitapAdi = dr["KitapAdi"].ToString();
                kitaps.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                kitaps.YazarId = Convert.ToInt32(dr["YazarId"]);
                kitaps.RafNo = dr["RafNo"].ToString();

                kitap.Add(kitaps);
            }

            con.Close();
            return kitap;
        }
    }
}
