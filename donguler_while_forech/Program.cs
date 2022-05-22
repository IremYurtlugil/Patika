using System;

namespace donguler_while_forech
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar sayı dahil ortalama hesaplayıp console a yazdıran program

            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi) //içerisine yazdığımız ifade true olduğu müddetçe while devam edecek.
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // a' dan z'ye kadar tüm harfleri console a yazdırma.
            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }


            Console.WriteLine("forech döngüsü");

            //Dizi için kullanılır.

            string[] arabalar = {"BMW","Ford", "Toyota","Nissan"};

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
