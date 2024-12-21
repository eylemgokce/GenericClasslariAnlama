using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslariAnlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic sınıfların avantajları : her türlü veriyle çalışabilme

            /*
              Hikaye:
                Bir kütüphanede kitaplar, dergiler ve DVD'ler saklanıyor. 
                Kütüphane görevlisi, her türden eşyayı yönetmek için bir sistem geliştirmek istiyor. 
                Ancak bu eşyalar farklı türden olduğu için her biri için ayrı ayrı sınıflar 
                yazmak zorunda kalıyor. Bir süre sonra bu kod tekrarlarından bıkıyor ve çözüm 
                arayışına giriyor. Tam bu sırada generic sınıfların mucizesiyle tanışıyor.
             */


            //Kitap koleksiyonu
            var kitapKoleksiyonu = new Koleksiyon<Kitap>(); //kitap türünde özel bir koleksiyon oluşturur.Bu koleksiyon yalnızca kitap türündeki nesnelerle çalışır.
            kitapKoleksiyonu.Ekle(new Kitap { Baslik = "1984", Yazar = "George Orwell" });
            kitapKoleksiyonu.Ekle(new Kitap { Baslik = "İçimizdeki Şeytan", Yazar = "Sabahattin Ali" });


            //Dergi koleksiyonu
            var dergiKoleksiyonu = new Koleksiyon<Dergi>();
            dergiKoleksiyonu.Ekle(new Dergi { Baslik = "Bilim ve Teknik", SayfaSayisi = 80 });
            dergiKoleksiyonu.Ekle(new Dergi { Baslik = "Atlas", SayfaSayisi = 100 });


            //DVD koleksiyonu
            var dvdkoleksiyon = new Koleksiyon<DVD>();
            dvdkoleksiyon.Ekle(new DVD { Baslik = "Inception", Sure = 2.5 });
            dvdkoleksiyon.Ekle(new DVD { Baslik = "Matrix", Sure = 2.0 });


            //Tüm koleksiyonları listeleme
            Console.WriteLine("Kitap koleksiyonu:");
            kitapKoleksiyonu.Listele();
            Console.WriteLine();

            Console.WriteLine("Dergi koleksiyonu");
            dergiKoleksiyonu.Listele();
            Console.WriteLine();

            Console.WriteLine("DVD koleksiyonu");
            dvdkoleksiyon.Listele();

            Console.ReadKey();
        }
    }
}
