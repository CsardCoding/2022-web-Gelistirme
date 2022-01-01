using System;

namespace ConsoleApp1
{

    //Bazen aynı isimli birden fazla methot tanımlamak isteyebiliriz bu durumda parametre sayılarını değiştirerek aynı isimde aşırı yüklenmiş methodlar oluşturabiliriz..
    //Yukardaki bahsedilen durumlarda methodlara overoyding aşırı yüklenmiş methotlar deniyor.
    class islem
    {
        public int topla(int a, int b)
        {
            return a + b;
        }

       
        //Aşırı yüklenmiş halini yapalım
        //parametre tipleri değişemez parametre tiplerine göre methodları aşırı yüklemiş olmuyoruz.

        public int topla(int a, int b, int c)
        {
            return a + b + c;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //yukardaki tanımladığım islem classna ait asırı yüklenmiş methodları kullanalım
            //önce bir nesne türetelim
            islem islem1 = new islem();
            Console.WriteLine(islem1.topla(1, 8));
            Console.WriteLine(islem1.topla(1,8,10));
        }
    }
}
