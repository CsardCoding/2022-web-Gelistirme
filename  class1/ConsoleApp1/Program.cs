using System;

namespace ConsoleApp1
{
    class ogrenci
    {
        public int ogrNo { get; set; }
        public string ogrAdi { get; set; }
        public string ogrSube { get; set; }

        public void yazıdr()
        {
            Console.WriteLine($"ogrNo:{this.ogrNo} ogrAdi:{this.ogrAdi} ogrSube:{this.ogrSube}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var ogr1 = new ogrenci();
            ogr1.ogrNo = 15;
            ogr1.ogrAdi = "Atakan";
            ogr1.ogrSube = "11B";

            ogr1.yazıdr();

            //nesne türetme
            ogrenci ogr2 = new ogrenci()
            {
                ogrNo=10,
                ogrAdi="Recep",
                ogrSube="12A"
            };
            ogr2.yazıdr();

            //tüm türetilen nesneleri bir dizi içine attığımızda böylece bu dizi üstünde dolaşarak öğrenci classından türetilen
            //öğrencilere kolyualıkla ulaşabiliriz. ve bunlar üzeirnde bir for yardımıyla dönebilirim

            Console.WriteLine("**********************");
            ogrenci[] ogrenciler = new ogrenci[2]; //2 elemanlı olacağını söyledik.
            ogrenciler[0] = ogr1;
            ogrenciler[0] = ogr2;


            for (int i=0; i<=ogrenciler.Length;i++)
            {
                Console.WriteLine($"ogrNo:{ogrenciler[i].ogrNo} ogrAdi:{ogrenciler[i].ogrAdi} ogrSube:{ogrenciler[i].ogrSube}");
            }

            


        }
    }
}
