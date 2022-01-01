using System;

namespace ConsoleApp1
{
    class Program
    {

        //yapıcı methodlar
        //normalde classtan nesne türetitkten sonra ilgilli propertilere değer ataması yapıyoruz. peki biz nesne oluşturulma anında değer ataması yapamazmıyız işte burda yardımımıza yapıcı methotlar koşuyor.
        //yapıcı methotlar class ismi ile yanı geri dönüş değeri olmayacak ama yine erişim belirteci olacak.
        //yapıcı methodlarda aynı methodların mantığı ile tıpkı onun gibi aşırı yüklenmiş hale getirilebilir.

       class urun
        {
            public urun()
            {
                Console.WriteLine("yapıcı method çalıştırıldı");
                this.fiyat = 10; //dışardan fiyat girilmedikçe bu urunun fiyatı bu olacak
            }
            public urun(double _fiyat)
            {
                this.fiyat = _fiyat;
               

            }
            public urun(int _urunid, string _urunadi, double _fiyat)
            {
                this.urunid = _urunid;
                this.urunadi = _urunadi;
                this.fiyat = _fiyat;

            }

            public int urunid { get; set; }
            public string urunadi { get; set; }
            public double fiyat { get; set; }
        }
        static void Main(string[] args)
        {
            urun urun1 = new urun(); //nesne oluşturulduğu anda yapıcı methodumuz çalıştırıldı
            //yapıcı methodu urun1 uzerinden çağırdığımızda ne olacak 
            Console.WriteLine($"urun1 nin fiyatu :{ urun1.fiyat}");

            urun urun2 = new urun(50);

            //Aşırı yüklenmiş yapıcı methodu urun2 üzerinden çağırdığımda ne olacak 
            Console.WriteLine($"urun2 nin fiyatu :{ urun2.fiyat}");

            //yeni bir nesne oluşturup tüm parametreleri alan aşırı yüklenmiş yapıcı metyhodu kullanalım
            urun urun3 = new urun(15,"makarna",4.90);
            Console.WriteLine($"urun3 id :{ urun3.urunid} urunadi:{urun3.urunadi} urun fiyatı:{urun3.fiyat} ");
        }
    }
} 
