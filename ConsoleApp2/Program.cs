namespace ConsoleApp2
{
    internal class Program
    {   //Veriyi Sürekli olarak Bellekte tutamak istersen 
        static int sayi = 5;


        static void Main(string[] args)
        {
            //byte a; //Veri Tipi : byte, ismi: a 
            //byte b;
            //a = 10;
            //b = 20;

            //byte c = 30;
            //byte d = 40, e;
            //e = 50;

            //byte f, g; şekilinde de kullanılabilir 
            //f = 60
            //g = 70;

            //Veri tipini değişilemez olarak kullanmak istenirse (değeri sonradan değiştiremezsin)
            //(const byte Number = 30;)


            //Number = 40;(Hata verecektir çğnkü değiştirilemez)

            //byte yas ;
            //console.writeline(yas);İçeriği yazılmamış olan değerleri yazamaz Hata verir 

            //Byte sayi = 256;(Hatalıdır çünkü 1-255 arası sayıları tutar)
            //İnt = 32 bitlik sayılar için kullanılır ( 2 üzeri 32)
            //Sbyte(8 bit) = -128 ile 127 arasında değer alır (2 üzeri 8)
            //Short = 32bin küsür arası sayılar barındırır (2 üzeri 16)
            //Ushort = -+ 32bin küsür arası sayıları barındırır (-+2 üzeri 16)
            //Long =(2 üzeri 64)

            //Bu değerler RAM'in Stack kısmında bulunur. 
            int number = 0;

            //Float metodunu kullanırken sayının sonuna f koymanı ister.
            float sayi = 3.15f;

            //Double metodunda Float'a göre sonuna d koyulması zorunlu değildir. 
            double a = 3.13; //veya double a = 3.13D;

            var sayii = 5.25m; // Implicit (Veri tipinin açık belirtilmediği durum)
            double number_1 = 5.25;//Explicit (Veri tipinin açıkça belirtildiği durum)

                    //Temel Veri Türleri

            //True veya False verilerini tutar
            bool sonuc = false;

            //Tek değerleri tutar ve (') Tek tırnak ile yazılmalıdır 
            char c = 'A';
            //unicod evrensel harf listesi
            char a = '\u0041';

            //metinsel ifadeleri tutan metoddur 
            string isim = "mehmet";

            string soyad = "kompi";



            Console.ReadKey();
        }
    }
}
//namespace:içinde classları bulunduran yapılardır
//{} scope(blok) yapilaridir
//class:içinde metodları bulunduran yapılardır ilerleyen konularda detaylanacak
//metod iş yapan kod bloklarıdır
//main metodu console uygulamalarini giris noktasidir her console uygulamasi main metodu ile baslar
//ctrl+f5 hata ayiklama modu olmadan programi caistirir
//Metod veya Classları seçtikten sonra F12 tuşuna basarak gidilir 


//syntax programlama dilleri yazim kurallari:

//1-acilan parantezler mutlaka kapatilmalidir
//2-scop tanimlamaliririn sonunda ; bulunmaz
//3-satirlarin sonunda ; bulunur
//4-metodlarin sonunda mutlaka duz parantez bulunur


//syntax hatasi olursa program derlenmez dolayisiyla calismaz vs hata olan yerin altini kirmizi cizgi ile isaretler bununla birlikte scroolbar'da kirmizi bir isaretle hatanin yerini bildirir
//vs penceresinin alt kisminda da kirmizi bir carpi isarti, yaninda da kac hata mesaji oldugunu gosterir.

//intellisense kod yazrkenb yardimci olan, acilan pencere
//solution explorer: solution'inimiz icindeki ulasabilecegimiz penceredir. view menusu araciligi ile acilabilir
//solution: bir ya da birden fazla proje icerebilirler

//CTRL+K+C secili metinleri yorum satirina donusturur
//CTRL+K+U yorum satirlarini normal koda donusturur
//CTRL+K+D kod satirlarini duzenler
//CTRL+B derleme yapar

//C# -> derleme -> MS-IL -> derleme (.NET Runtime) -> 0-1 (binary)
//MS-IL microsoft intermediate language

//1 bit = 0 veya 1
//8 bit = 1 byte 
//1 Kilo Byte = 1024 Byte
//1 Mega Byte = 1024 Kilo Byte
//1 Giga Byte = 1024 Mega Byte 
//1 Tera Byte = 1024 Giga Byte 


