using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Atama ve işlemli atama
           int x = 3;
           int y = 3;
           y= y+2;
           Console.WriteLine(y);
           y+=2; //işlemli atama
           Console.WriteLine(y);
           y/=1;
           Console.WriteLine(y);
           x*=2;
           Console.WriteLine(x);

           //Mantıkal operatörler
           // || , && , !
           bool isSuccess = true;
           bool isCompleted = false;
           if(isSuccess && isCompleted)
           Console.WriteLine("perfect");
           if(isSuccess || isCompleted) 
           Console.WriteLine("great");
           if(isSuccess && !isCompleted)
           Console.WriteLine("fine");

           //İlişkisel operatörler
           // <, >, <=, >=, ==, !=
           Console.WriteLine("İlişkisel operatörler");

           int a =3;
           int b=4;
           bool sonuc = a<b;
           Console.WriteLine(sonuc);
           sonuc= a>b;
           Console.WriteLine(sonuc);
           sonuc= a>=b;
           Console.WriteLine(sonuc);
           sonuc= a<=b;
           Console.WriteLine(sonuc);
           sonuc= a==b;
           Console.WriteLine(sonuc);
            sonuc= a!=b;
           Console.WriteLine(sonuc);

           //Aritmatik operatörler
           // /,*,+,-

           int sayi =10;
           int sayi2 = 5;
           int sonuc1 = sayi/sayi2;
           Console.WriteLine(sonuc1);
           sonuc1 = sayi*sayi2;
           Console.WriteLine(sonuc1);
           sonuc1 = sayi+sayi2;
           Console.WriteLine(sonuc1);
          //sayi += 1;
          sonuc1 = sayi++;
           Console.WriteLine(sayi);

           // % mod almak için kullanılır

           int  sonuc2=20%3;
           Console.WriteLine(sonuc2);




        }
    }
}
