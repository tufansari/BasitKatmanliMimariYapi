using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // kütüphaneye sql tanımladık


namespace DataAccessLayer
{
    
    public class DataAccessLayer // DAL classı oluşuturup bağlantıyı kurduk.
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=404-07;Initial Catalog=nlayer;User ID=sa;Password=1234");
    }
}
