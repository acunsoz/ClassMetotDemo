using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Cam";
            musteri1.id =56894;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Tat";
            musteri2.id = 56823;
            
            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Kadir";
            musteri3.Soyadi = "Tik";
            musteri3.id = 56846;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Merve";
            musteri4.Soyadi = "Dam";
            musteri4.id = 56872;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4 };
            
            foreach (var musterin in musteriler)
            {
                Console.WriteLine("Musterilerin Kimligi\n");
                Console.WriteLine("Musteri adi: "+musterin.Adi);
                Console.WriteLine("Musteri soyadi: "+musterin.Soyadi);
                Console.WriteLine("Musteri id: "+musterin.id);
                Console.WriteLine("--------------");

            }


            MusteriManager islem = new MusteriManager();
            

            islem.Ekle(musteri4);
            islem.Ekle(musteri2);

            islem.Sil(musteri3);
            islem.Sil(musteri1);


        }
    }
}
