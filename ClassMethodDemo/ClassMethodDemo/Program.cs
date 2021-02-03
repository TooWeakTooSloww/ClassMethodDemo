using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************* MÜŞTERİ TAKİBİ UYGULAMASI **********");
            
            
            
            Musteri mus1 = new Musteri();
            mus1.Adi = "Bilal";
            mus1.Soyadi = "Bora";
            mus1.Id = 003;
            mus1.KrediPuani = 85;

            Musteri mus2 = new Musteri();
            mus2.Adi = "Hilal";
            mus2.Soyadi = "Bora";
            mus2.Id = 004;
            mus2.KrediPuani = 95;

            Musteri mus3 = new Musteri();
            mus3.Adi = "Halil";
            mus3.Soyadi = "Bora";
            mus3.Id = 003;
            mus3.KrediPuani = 60 ;

            Musteri[] musteriler = new Musteri[] { mus1, mus2, mus3 };

            

            Console.WriteLine("MÜŞTERİ BİLGİLERİ");

            foreach (Musteri gezinti in musteriler)
            {
                Console.WriteLine("Müşteri Adı = " + gezinti.Adi);
                Console.WriteLine("Müşteri Soyadı = " + gezinti.Soyadi);
                Console.WriteLine("Müşteri Id = " + gezinti.Id);
                Console.WriteLine("Müşteri KrediPuanı = " + gezinti.KrediPuani);
                Console.WriteLine("---------------------------");            
            }





            Console.WriteLine("\n Müşteri hareketleri");


            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekle(mus1);
            MusteriManager.Sil(mus2);
            MusteriManager.Kredi(mus3);
            

            



























        }
    }
}
