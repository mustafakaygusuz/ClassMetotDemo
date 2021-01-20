using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Bankamıza Kayıtlı Müşterinin Adı :  " + musteri.MusteriAd + " Soyadı : " + musteri.MusteriSoyad + " Yaşı :  " + musteri.MusteriYas);
        }
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Aramıza Hoşgeldin : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " Bankamızdaki Hesabınız silinmiştir.");
        }
    }
}
