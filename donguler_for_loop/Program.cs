using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayıya kadar olan tek sayılar");
            for (int i = 1; i <=sayac; i++)
            {                
                if (i%2 ==1)
                {                 
                    Console.WriteLine(i);
                }               
            }
            }
            catch (Exception ex)
            {
                
               Console.WriteLine(ex.Message.ToString().ToUpper());
            }


            // 1-1000 arasındaki tek ve çift sayıların kendi içinde toplamını yazdırma

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if(i%2==1)
                tekToplam +=i; // tekToplam = tekToplam + i ;
                else
                ciftToplam += i;                
            }
            Console.WriteLine("Tek sayıların toplamı = " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı = " + ciftToplam);

            //*** break , continue
            for (int i = 1; i <10; i++)
            {
                // if(i==4)
                // break;
                // Console.WriteLine(i);
                if(i==4)
                continue;
                Console.WriteLine(i);
            }

        }
    }
}
