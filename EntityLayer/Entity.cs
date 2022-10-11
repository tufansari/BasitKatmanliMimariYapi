using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
     public class Entity // önce entity classı oluşturup sql veri tabanındaki verilere eş değer değişkenler oluşturuyoruz.
    {
        
        
            private int id; // ctrl + r + e yapıp alt tarafta linq'larını alıyoruz.
            private string ad;
            private string soyad;
            private string sehir;
            private string gorev;
            private short maas; // sql'de smallint console'da short'a eşittir.

            public int Id { get => id; set => id = value; }
            public string Ad { get => ad; set => ad = value; }
            public string Soyad { get => soyad; set => soyad = value; }
            public string Sehir { get => sehir; set => sehir = value; }
            public string Gorev { get => gorev; set => gorev = value; }
            public short Maas { get => maas; set => maas = value; }
        
    }
}
