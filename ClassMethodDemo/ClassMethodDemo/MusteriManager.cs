using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listeye Eklendi");
        }
        
        
        
        
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void Kredi(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyadi + " isimli müşterinin  kredi puanı = " + musteri.KrediPuani);
        }







    }
}
