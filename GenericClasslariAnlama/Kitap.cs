using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslariAnlama
{
    internal class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }

        public override string ToString() //ToString metotu , bir nesneyi anlamlı bir string formatında döndürmek için özelleştirilmiş bir metottur.
        {
            return "Kitap : " + Baslik + " | Yazar : " + Yazar;
        }
    }
}
