using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Emircan";
            musteri1.MusteriSoyad = "Dumlu";
            musteri1.MusteriYas = 18;
            musteri1.MusteriTc = "12345678901";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Ahmet Emre";
            musteri2.MusteriSoyad = "Sakarya";
            musteri2.MusteriYas = 17;
            musteri1.MusteriTc = "12345678902";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "Mustafa İlhan";
            musteri3.MusteriSoyad = "Kaygusuz";
            musteri3.MusteriYas = 18;
            musteri3.MusteriTc = "12345678903";

            Console.WriteLine("-----------------Musteri Array-----------------");

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Bankamıza Kayıtlı Müşterinin Adı - Soyadı : " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " - Yaşı : " + musteri.MusteriYas + " - TcNo : " +musteri.MusteriTc );
            }
            Console.WriteLine("-----------------Musteri Manager-----------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriSil(musteri1);

        }
    }
}
