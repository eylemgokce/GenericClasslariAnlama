using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslariAnlama
{
    internal class Dergi
    {
        public string Baslik { get; set; }
        public int SayfaSayisi { get; set; }

        public override string ToString()
        {
            return "Dergi : " + Baslik + " | Sayfa sayısı : " + SayfaSayisi;
        }
    }
}
