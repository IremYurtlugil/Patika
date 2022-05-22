using System;

namespace tip_dönüsümleri
{
    class Program
    {
        static void Main(string[] args)
        {
           // Implicit Conversion (Bilinçsiz Dönüşüm)[Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanma işlemi. Çevrim kodu yazılmasına gerek yok çevrim makina trf gerçekleşiyor]

           Console.WriteLine("Implicit Conversion");

           byte a = 5;
           sbyte b = 30;
           short c = 10;
           
           int d = a+b+c; //int diğer değişkenleri de kapsadığı için herhangi hataya sebep olmadı. 
           Console.WriteLine("d:" + d);

           long h=d;
            Console.WriteLine("h:" + h);
            
            float i = h;
             Console.WriteLine("i:" + i);

             string e = "İrem";
             char f = 'k';
             object g = e+f+d; //obje tüm değişkeleri de kapsadığından bizim ekstra bir işlem yapmamıza gerek kalmadan dönştürme işlemini gerçekleştirir.
             Console.WriteLine("g:" + g);

           //Explicit Conversion (Bilinçli Dönüşüm) [C# trf yapılamayan dönğşğümler. Bu sebeple kullanıcı dönüşümleri kendisi yapmalıdır. Convert, Parse, ToString...]

           Console.WriteLine("Explicit Conversion");

           int x = 4;
           byte y = (byte)x ; //int byte göre büyük bir değişken olduğu için kendi kendine dönüşüm olamaz bu sebeple cast işlemi ile dönüşüm gerçekleştirilir.
           //Cast işlemi atanan değer önündeki parantez içine hedef veri tipinin  yazılması ile tür dönüşümü sağlanır.
           Console.WriteLine("y:" + y);

           int z = 100;
           byte t = (byte)z;
           Console.WriteLine("t:" + t);

           float w = 10.3f;
           byte v =(byte)w;
           Console.WriteLine("v:" + v ); // Output : 10 olur. Çevrimlerde veri kaybına örnek

           //ToString Methodu
           Console.WriteLine("ToString Methodu");
           int xx = 6;
           string yy = xx.ToString();
           Console.WriteLine("yy;" +yy);

           string zz = 12.5f.ToString();
           Console.WriteLine("zz:"+ zz);

           //system.Convert Sınıfı
           Console.WriteLine("system.Convert Sınıfı");
           string s1 = "10", s2 ="20";
           int sayi1, sayi2;
           int toplam;
           sayi1 = Convert.ToInt32(s1); //String olan s1 değerini int olan sayi1 değişkenine int değişkeni ile atadık. Böylece sayısal değer elde etmiş olduk.
           sayi2 = Convert.ToInt32(s2);
           toplam = sayi1+sayi2;
           Console.WriteLine("Toplam:" +toplam);

           //Parse Methodu

            Console.WriteLine("Parse Methodu");
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1:"+ rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("double1:"+ double1);
        }
    }
}
