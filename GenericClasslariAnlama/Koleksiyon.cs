using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslariAnlama
{
    internal class Koleksiyon<T>
    {
        private List<T> esyalar = new List<T>();

        public void Ekle(T esya)
        {
            esyalar.Add(esya);
        }

        public void Listele()
        {
            foreach (var esya in esyalar)
            {
                Console.WriteLine(esya);
            }
        }
    }
}
