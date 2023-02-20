using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.stokAdedi = 47;
            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 15;

            Product[] urunler = new Product[] {urun1 , urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------------------");

            sepetManager.Ekle2("Armut", "Yeşil armut" , 12 , 10);
            sepetManager.Ekle2("Elma", "Yeşil elma" , 12 , 9);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz" , 12 , 8);



            Console.ReadLine();
        }
    }
}

// Dont repeat yourself - Clean code
