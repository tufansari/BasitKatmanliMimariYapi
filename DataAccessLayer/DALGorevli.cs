using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer; // kütüphaneye entitylayer'i ekledik.


namespace DataAccessLayer
{
    public class DALGorevli // bağlantıları oluşturacağımız classı kurduk.
    {
        public static List<Entity> Personellistesi() // listeleme için metot.

        {
            // personel listesinin listelenmesini sağlayan kod.
            List<Entity> deger = new List<Entity>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_gorevli", DataAccessLayer.baglanti);
            if (komut1.Connection.State !=
                System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                Entity ent = new Entity();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString()); // smallint tanımladığımız için short kullanıyoruz.
                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }
        public static int Personelekle(Entity n) // ekleme için metot.
        {
            SqlCommand komut2 = new SqlCommand("Insert into  tbl_gorevli (AD,SOYAD,SEHIR,GOREV,MAAS) Values (@p1,@p2,@p3,@p4,@p5)", DataAccessLayer.baglanti);
            if (komut2.Connection.State !=
               System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", n.Ad);
            komut2.Parameters.AddWithValue("@p2", n.Soyad);
            komut2.Parameters.AddWithValue("@p3", n.Sehir);
            komut2.Parameters.AddWithValue("@p4", n.Gorev);
            komut2.Parameters.AddWithValue("@p5", n.Maas);
            return komut2.ExecuteNonQuery();
        }
        public static bool Personelsil(int p) // silme için metot.
        {
            SqlCommand komut3 = new SqlCommand(" Delete from tbl_gorevli where ID=@p1", DataAccessLayer.baglanti);
            if (komut3.Connection.State !=
              System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery()>0;
        }
        public static bool Personelgüncelle(Entity n)
        {
            SqlCommand komut4 = new SqlCommand(" Update tbl_gorevli set AD=@p1,SOYAD=@p2,SEHIR=@p3,GOREV=@p4,MAAS=@p5 where ID=@p6", DataAccessLayer.baglanti);
            
            if (komut4.Connection.State !=
              System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.Ad);
            komut4.Parameters.AddWithValue("@p2", n.Soyad);
            komut4.Parameters.AddWithValue("@p3", n.Sehir);
            komut4.Parameters.AddWithValue("@p4", n.Gorev);
            komut4.Parameters.AddWithValue("@p5", n.Maas);
            komut4.Parameters.AddWithValue("@p6", n.Id);
            return komut4.ExecuteNonQuery() > 0;

        }
    }
}
