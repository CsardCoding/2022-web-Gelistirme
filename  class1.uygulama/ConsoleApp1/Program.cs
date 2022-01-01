using System;

namespace ConsoleApp1
{

    class urun
    {
        public int urunid { get; set; }
        public string urunadi { get; set; }
        public double fiyat { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adet:");
            var adet = int.Parse(Console.ReadLine());
            urun[] urunler = new urun[adet];

            int i = 0;
            urun urun1;

            do
            {
                urun1 = new urun();
                Console.WriteLine("urun id:");
                urun1.urunid = int.Parse(Console.ReadLine());
                Console.WriteLine("urun adi:");
                urun1.urunadi = Console.ReadLine();
                Console.WriteLine("urun fiyatı");
                urun1.fiyat = double.Parse(Console.ReadLine());

                urunler[i] = urun1;
                i++;

            } while (adet!=i);

            Console.WriteLine("***********************");

            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine($"urunid:{urunler[a].urunid} urunadi:{urunler[a].urunadi} urun fiyatı {urunler[a].fiyat}");
            }
        }
    }
}
