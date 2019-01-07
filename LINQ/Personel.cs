using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Personel
    {
        public int Yas { get; set; }
        public decimal Maas { get; set; }

        Random r = new Random();
        public Personel()
        {
            Yas = r.Next(25, 50);
            Maas = r.Next(2100, 10000);
        }
    }
}
