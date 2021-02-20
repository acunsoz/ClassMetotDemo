using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi: "+musteri.Adi);
            Console.WriteLine("-------------");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi: "+musteri.Adi );
            Console.WriteLine("---------------");
        }
       
    }
}
