using System;

namespace ConsoleApp1
{
    class yorum // herbir urune yapılan yorumları taşıyacak olan class, ben bu cclası urun classı içinde properti alanına dizi olarak ekleyeceğim
    {
        public int yorumid { get; set; }
        public string yorumText { get; set; }
    }

    class urun
    {
        //nesne urettikten sonra değer properti alanlarına değer ataması yaparız ancak bazı zamanlar biz bunlarla uğraşmak istemeyiz. 
        //o yüzden gelirisz bilgili class içine bir kanstaktır oluştururusz.(ctor+tab+tab)

        public urun()
        {
            this.urunid = (new Random()).Next(1, 999);
            this.yorumlar = new yorum[100];//bunun yeri burasıdır. burada da bire değişiklik yapacağız ama ilerde peki ben bunu diper kantraktırlarda da kullanmak istersem
                                           //tek tek bu satırı hepsine eklemem gerekir ama bunu yapmaya gerek yok bunun yerine :this() dediğinizde bu kastraktır çalıştırılmadan
                                           //önce 1. kantraktır çalıştırıldın demiş oluyoruz.

        }
        //yapıcı methodun aiırı yüklenmiş halini yapalım.
        //aşağıda urun id sini kullanıcı kendisi belirleyebilecek belirlemez ise sistem otomatik kendisi atayacak
        public urun(int _urunid):this()
        {
            this.urunid = _urunid;
        }

        //nesne uretme aşamasında verileri bizim girebileceğimiz bir kanstraktır daha olulşturalım
        public urun(int _urunid, string _urunadi, double _urunfiyat, bool _satışonay):this(_urunid) //bu alanı yazdıktan sonra : sonrasını bu buloktaki this.urunid=_urunid kısmını sildim burayı
                                                                                                    //2 kanstraktıdan alacak nedeni 1 kantraktır da urunid rasgele atıyor böylece 2. kantraktır içinde
                                                                                                    //_urunid set edildi
        {
          
            this.urunadi = _urunadi;
            this.urunfiyat = _urunfiyat;
            this.urunonay = _satışonay;

        }

        public int urunid { get; set; }
        public string urunadi { get; set; }
        public double urunfiyat { get; set; }

        public bool urunonay { get; set; }

        public yorum[] yorumlar { get; set; } //başka bir classı buraya properti olarak ekledim tab' bunun new keywordu ile oluşturuyor olmamız gerekirdi bunuda aşağıda yapacağız.
    }
    class Program
    {
        static void Main(string[] args)
        {

            //_________________________________________gelelim buraya bier yorum nesnesi türetelim___________________________________

            var yorum1 = new yorum();
            yorum1.yorumid = 1;
            yorum1.yorumText = "Bu 1. Ürün";
            //burdaki yorum1 i urun clasının içinde yer alan yorum propertisine göndermemiz gherekir.


            var yorum2 = new yorum();
            yorum2.yorumid = 2;
            yorum2.yorumText = "Bu 2. ürün";



            var yorum3= new yorum();
            yorum3.yorumid = 2;
            yorum3.yorumText = "Bu 3. ürün";

            //_________________________________________urun nesnesi türetelim___________________________________

            var urun1 = new urun();
            //urun1.yorumlar = new yorum[1];___//bunun yeri burası değişdir 
            urun1.yorumlar[0] = yorum1;
            //urun1.urunid = 15;
            //urun1.urunadi = "yumos";
            //urun1.urunfiyat = 27;
            //urun1.urunonay = true;


            Console.WriteLine($"urun id:{urun1.urunid} urun adi:{urun1.urunadi} urun fiyatı:{urun1.urunfiyat} urun satıştamı:{urun1.urunonay} yorumlar:{urun1.yorumlar[0].yorumText}");

            //aşlırı yüklenmiş yapıcı methodu kullanarak bir nesne uretilem
            var urun2 = new urun(15);
            urun2.yorumlar[0] = yorum2;
            Console.WriteLine($"urun id:{urun2.urunid} urun adi:{urun2.urunadi} urun fiyatı:{urun2.urunfiyat} urun satıştamı:{urun2.urunonay}  yorumlar:{urun2.yorumlar[0].yorumText}");

            //yukarda oluşturduğum kantraktır sayesinde nesne oluşturma anında bilgileri girebileceğim  nesne uretmeye bu bir altarnatiftir.
            var urun3 = new urun(1,"turşu", 15.80, true);
            urun3.yorumlar[0] = yorum3;
            Console.WriteLine($"urun id:{urun3.urunid} urun adi:{urun3.urunadi} urun fiyatı:{urun3.urunfiyat} urun satıştamı:{urun3.urunonay} yorumlar:{urun3.yorumlar[0].yorumText}");






        }
    }
}
