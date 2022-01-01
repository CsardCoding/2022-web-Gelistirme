using System;

namespace ConsoleApp1
{
    class person
    {
        public string name { get; set; }
        public int yil { get; set; }

        //Asağıdaki nesneleri ekrana yazdıracak methodu tanımlayalım
        //halka acık methot olacak ve ilgili classtan türeyen tüm nesneler bu methoda ulaşabilecek bu yüzden public oalrak belirtiyorum
        public void ekranabas()
        {
            Console.WriteLine($"person name:{this.name} person doğum yılı:{this.yil}");
        }

        //yaş hesaplama methodunu oluşlturuyorum
        public void yas_hesaplama()
        {
            Console.WriteLine(2021-this.yil);
        }
       
        //web alanında console... komutlarını kullanamayız bu yüzden yeni bir methot tanımlayayım görmüş olun
        //bunu kullanırkende yanı biz bunu consolda görmek istiyoruz o zaman bu methodu yakalıyor olmamız gerekir.
        public string isimcek()
        {
            return $"peronel ismi{this.name}";

        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //classtan nesne türetirken uzun uzun class keyvordunuda yazmanıza gerek yok var keywordunuda kullanabilirsiniz.

            person p1 = new person() {name="Recep", yil=1993};
            var p2 = new person() { name = "Atakan", yil = 2021 };
            person p3 = new person() { name = "Gökçe", yil = 2018 };

            p1.ekranabas();
            p1.yas_hesaplama();


            //methodu yakalayalım
            var yakala = p1.isimcek();
            Console.WriteLine(yakala);
        }
    }
}
