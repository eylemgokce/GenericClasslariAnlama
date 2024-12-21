using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslariAnlama
{
    internal class DVD
    {
        public string Baslik { get; set; }
        public double Sure { get; set; } //süre saat cinsinden

        public override string ToString()
        {
            return "DVD : " + Baslik + " | Süre : " + Sure;
        }
    }
}
