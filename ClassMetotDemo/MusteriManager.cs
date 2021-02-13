using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd + " " + musteri.musterıSoyad + " " + "sisteme eklendi.");
        }

        public void deleteCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd + " " + musteri.musterıSoyad + " " + "sistemden silindi.");
        }

        public void updateCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd + " " + musteri.musterıSoyad + " " + "isim-soyisimli kişinin bilgileri güncellendi.");
                
        }
        
        
        public void musteriListeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Müşterinin Id numarası : " + musteri.musteriId);
                Console.WriteLine("Müşterinin TC Kimlik Numarası : " + musteri.musteriTc);
                Console.WriteLine("Müşterinin Adı Soyadı : " + musteri.musteriAd + " " + musteri.musterıSoyad);
                
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("Listeleme işlemi tamamlandı.");
        }
    }

    

}
