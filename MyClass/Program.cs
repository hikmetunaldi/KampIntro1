using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunMarkasi = "adidas";
            urun1.UrunAdi = "VS PACE Gri Erkek Sneaker Ayakkabı 100292488 B74318 ";
            urun1.UrunKalanAdetSayisi = 431;
            urun1.UrunOzellikler = "Gri+Erkek Ayakkabı+Sneaker";
            urun1.UrunFiyatı = 836;

            Product urun2 = new Product();
            urun2.UrunMarkasi = "HUMMEL";
            urun2.UrunAdi = "Porter Lacivert Unisex Ayakkabı 207900-9001";
            urun2.UrunKalanAdetSayisi = 261;
            urun2.UrunOzellikler = "Lacivert+Unisex+Porter";
            urun2.UrunFiyatı = 379;

            Product urun3 = new Product();
            urun3.UrunMarkasi = "Bershka";
            urun3.UrunAdi = "Beyaz - Kontrast Spor Ayakkabı 12438060";
            urun3.UrunKalanAdetSayisi = 588;
            urun3.UrunOzellikler = "Beyaz+Unisex+Konstrast";
            urun3.UrunFiyatı = 379;

            Product[] urunler = new Product[] {urun1 , urun2 ,urun3 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi+urun.UrunOzellikler+urun.UrunMarkasi+urun.UrunFiyatı+urun.UrunKalanAdetSayisi);
            }
            Console.WriteLine("Sayfa Sonu - footer");
            

            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunMarkasi + ":" + urunler[i].UrunAdi + ":" + urunler[i].UrunKalanAdetSayisi + ":" + urunler[i].UrunOzellikler + ":" + urunler[i].UrunFiyatı);

            }            
            Console.WriteLine("Sayfa Sonu - footer");
            int j = 0;

            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunMarkasi + ":" + urunler[j].UrunAdi + ":" + urunler[j].UrunKalanAdetSayisi + ":" + urunler[j].UrunOzellikler + ":" + urunler[j].UrunFiyatı);
                j++;
            }
            Console.WriteLine("Sayfa Sonu - footer");

          

            Console.ReadLine();
        }
        
    }
    class Product
    {
        public string UrunMarkasi { get; set; }
        public string UrunAdi { get; set; }
        public int UrunKalanAdetSayisi { get; set; }
        public string UrunOzellikler { get; set; }
        public int UrunFiyatı { get; set; }
    }
    
}
