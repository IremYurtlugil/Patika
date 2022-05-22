using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine()); //Console dan girilen değeri int dönüştürme
            Console.WriteLine("Girmiş olduğunuz sayı:" +sayi);
            }
            catch (Exception ex)
            {                
                Console.WriteLine("Hata mesajı"+ ex.Message.ToString());
            }
          /*  finally 
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            */
            try
            {
                //int a =  int.Parse(null); //boş değer hatası dönecek
               // int a = int.Parse("test"); //veri tipi uygun değil hatası
                int a = int.Parse("-20000000000"); //OverflowException hatası yani sınır değerlerinin aşılması hatası
            }
            catch (ArgumentNullException ex) //boş değer atandığı için null exception hatası verecek.
            {
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(ex);

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla gerçekleşti");
            }
        }
    }
}
