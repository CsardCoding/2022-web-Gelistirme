using System;

namespace ConsoleApp1
{
    class Program
    {


        //aşağıda urun class ına bağlı yaptığım özellikle private tanımlanan bir properties e public metod ile değer atamanın kısa bir yolu var gelin bunuda icecekler class i içinde görelimö
        class icecek
        {
            public string icecekadi;
            private double _İcecekFiyat;

            public double icecekFiyat
            {
                get
                {
                    //get içinde benden ne zaman fiyat alanı istenirse ben private olan değişkeni geriye göndereceğim
                    return this._İcecekFiyat;
                }
                set
                {
                    if (value > 0)
                    {
                        _İcecekFiyat = value;
                    }
                    else
                    {
                        _İcecekFiyat = 0;
                        Console.WriteLine("içeceklerin fiyatında negatif değer giremezsiniz");
                    }
                }
            }
        }



        //bu dersimizde properties kavramını öğrenelim
        //properties ler class içindeki değişkenlerdi ve public olarak tanımladndıklarında class dışındanda bu değişkenlere ulaşılabiliyor.
        //ama normal string, int, double gibi public olmadan ranımlama yaparsak class dışından bu değişkenlere ulaşılamıyor.
        //varsayılan olrak private özel dılarıya erişimi yasaklı olrak oluşmuş oluyor.
        //biz fiyat alanını double olarak belirtmek istersek dılardan negatif bir değer girsede program hata vermez çünkü double tipi negatif değerlerde albilir Fakat şöyle bir problemimiz var fiyat negatif olamaz
        //o zaman ben buraya ozel (private) türünde bir değişken tanımlayacağım ama dışardan da erişebilir olacak ve bu değişkeni kontrol edeceğim negatif olma durumunu

        class urun
        {
            public string urunadi { get; set; }
            public double urunfiyat { get; set; }

            //private olarak oluşturulmuş bir properties e puplic bir methot yardımıyla değer ataması yapabiliriz. cok öenmli unutma
            public void fiyatkontrol(double _fiyat) {

                if (_fiyat>0)
                {
                    this.urunfiyat = _fiyat;

                }
                else
                {
                    this.urunfiyat = 0;
                    Console.WriteLine("urnlerde fiyat alanını negatif değer giremezsiniz");
                }
            }

            //urunleri ekrana bastıracak methodumuzu hazırlayalım
            public void geturun()
            {
                Console.WriteLine($"urun adi:{this.urunadi} Ürün Fiyatı:{this.urunfiyat}");
            }
        }
        static void Main(string[] args)
        {

            urun urun1 = new urun(); 
            urun1.urunadi = "makarna";
            urun1.fiyatkontrol(-20);

            urun1.geturun();



            //_________icecek clasından nesne türetim negatif fiyat kontrolü yapalım_______
            icecek icelek1 = new icecek();
            icelek1.icecekadi = "Fanta";
            icelek1.icecekFiyat = -200;
            Console.WriteLine($"{icelek1.icecekFiyat}");
            icelek1.icecekFiyat = 200;
            Console.WriteLine($"{icelek1.icecekFiyat}");
            

        }
    }
}
