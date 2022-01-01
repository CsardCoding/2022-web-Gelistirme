using System;

namespace ConsoleApp1
{

    class islem //parametresiz methodu barındıran class

    {
        public int a { get; set; }
        public int b { get; set; }
        //toplama işlemi yapan methodumuzu tanımlıyorum. burada normal parametresiz bir method kullanacağım.
        public  int Topla()
        {
            return this.a + this.b;

        }

        
    }
    
    class parametreli_islem
    {
        //propertylleri tanımlamadan methot tanımlamasını yapabilirimn
        //parametreli methodlarda dikkat edilmesi gerekenler
        //1-öncelikle parametre sayısı kadar veri girişi yapılmalıdır.
        //2-veri girerken pislem1.parametreliToplam(y: 20, x: 100); hedef belirterek veri girilebilir.(buna isimlendirilmiş parametre denir.)
        //3-varsayılan parametre değer ataması yapabiliriz.(fakat burada dikkat edilemsi gerteken şey zorunlu parametreler başta zorunlu olmayan varsayılan değer ataması yaptığın parametreler sonda yer almalıdır.)
        public int parametreliToplam(int x, int y)
        {
            return x+y;
        }



        public int belirsiztoplam(params int[] sayılar)
        {
            int toplam = 0;

            foreach (var item in sayılar)
            {
                toplam += item;

            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //parametresiz methodu barındıran classtan işlem yapalım
            islem islem1 = new islem();
            islem1.a = 20;
            islem1.b = 30;

            Console.WriteLine($"a+b Toplamı: {islem1.Topla()}");


            //şimdide parametreli method barındıran classtan işlem yapalım

            parametreli_islem pislem1 = new parametreli_islem() {};

            Console.WriteLine(pislem1.parametreliToplam(10, 70));
            pislem1.parametreliToplam(y: 20, x: 100);


            //belirsiz parametreli toplam methodunu çalıştıralım
            Console.WriteLine("__________belirsiz parametreli işlem__________");
            parametreli_islem pislem2 = new parametreli_islem();
            Console.WriteLine(pislem2.belirsiztoplam(20,40,80,1000));

        }
    }
}
