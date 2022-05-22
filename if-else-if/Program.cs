using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour; //o an ki saati almak için
            if (time>=6 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time>=11 && time<18)
            {
                Console.WriteLine("Tünaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else 
            Console.WriteLine ("İyi geceler");

            //if kısa yazımı
             string sonuc = time<=18 ? "Merhaba iyi günler" : "Merhaba";
             sonuc = time>=16 && time<11 ? "Günaydın" : time<=18 ? "İyi Günler" : "İyi Geceler";
             Console.WriteLine(sonuc); //Console içerisine şart durumu da yazılabilir.
        }
       
    }
}
