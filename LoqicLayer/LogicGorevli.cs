using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace LoqicLayer
{
    public class LogicGorevli
    {
        public static object MessageBox { get; private set; }

        public static List<Entity> LLPersonellistesi()
        {
            return DALGorevli.Personellistesi();
        }
        
        public static int LLPersonelekle(Entity p)
        {
            if(p.Ad!= "" && p.Soyad!="" && p.Maas >= 4250)
            {
                
                return DALGorevli.Personelekle(p);
            }
            else
            {               
                return -1; // değer döndürme anlamına gelir.
            }
        }
        public static bool DLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DALGorevli.Personelsil(per);
            }
            else
            {
                return false; // değer döndürme anlamına gelir.
            }
        }
        public static bool LLPersonelguncelle(Entity p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 4250 && p.Ad.Length>=2) 
            {

                return DALGorevli.Personelgüncelle(p);
            }
            else
            {
                return false; // değer döndürme anlamına gelir.
            }
        }
    }
}
