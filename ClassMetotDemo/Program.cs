using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();


            Musteri musteri1 = new Musteri();
            musteri1.musteriTc = 78945612301;
            musteri1.musteriAd = "Ahmet";
            musteri1.musterıSoyad = "Öztürk";

            musteriManager.AddCustomer(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.musteriTc = 12345678910;
            musteri2.musteriAd = "Kerem";
            musteri2.musterıSoyad = "Yağcı";

            musteriManager.deleteCustomer(musteri2);

            Musteri musteri3 = new Musteri();
            musteri3.musteriTc = 45678912309;
            musteri3.musteriAd = "Ayça";
            musteri3.musterıSoyad = "Bağ";

            musteriManager.updateCustomer(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1 , musteri2 , musteri3 };
            musteriManager.musteriListeleme(musteriler);

        }
    }
}
