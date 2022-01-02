using System;

namespace ConsoleApp1
{

    class product
    { //bu propm alanların her biri veriTabanında kolonlora karşılık geliyor.
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public bool stok { get; set; }


    }

    //Burada sanal bir veritabanı oluşturalım yani product classından türeyen nesneleri yönetecek olan maneger sınıfından bahsediyorum bu snıf static olacak
    static class productDatabase
    {
        static product[] _products; //=new deyip değer atardıma ama şimdi atamayayım bu yapı nezaman kullanılırsa içine değerler o zaman geldisin. yani burda bir canstraktırdan bahsediyoruz (ctor)

        //yukarda bahsettiğim kanstrakterımı oluşturuyorum 
        static productDatabase()
        {
            //ancak burda statik bir sınıfın kantraktırı public yada başka bir belirtec ile belirtilmez ancak sınıf statik olduğu için mutlaka kanstrakter da static olacak
            _products = new product[3];
            //dizimizin 0. elemanına bir nesne türetelim
            _products[0] =new product{id=001,name="M8-Civat",price=0.35,stok=true};
            _products[1] = new product { id = 002, name = "M10-Civat", price = 0.45, stok = true };
            _products[2] = new product { id = 003, name = "M12-Civat", price = 0.49, stok = true };
        }


        //static alanları ekrana bastıran vir methodumuz olsun
        public static product[] GetProducts()
        {
            return _products;
        }

        //yine farklı methodlar oluşturabiliriz girilen id'ye göre ilgili urunu getiren methodu tanımlayalım

        public static product getproductid(int _id) //geri dönüş tipini product olarak belirttim
        {
            product urun = null;//gönderilecek bilgiyi tanımlayalım ve başlangıçta null olsun

            foreach (var p in _products)
            {
                if (p.id==_id)
                {
                    urun = p;
                }
            }


            return urun;

        }
    }
    



    class Program
    {
        static void Main(string[] args)
        {
            //static class a ait methodu burada kullanalım
            var productsList = productDatabase.GetProducts();//burdan dönen birliste var

            foreach (var item in productsList)
            {
                Console.WriteLine($"urun id:{item.id} urun adi:{item.name} urun fiyatı:{item.price} stokta varmı:{item.stok}");
            }

            Console.WriteLine("______________________");
            //static class a ait methodu burada kullanalım 
            var setid = productDatabase.getproductid(2);
            Console.WriteLine($"urun id:{setid.id} urun adi:{setid.name} urun fiyatı:{setid.price} stokta varmı:{setid.stok}");
        } 
    }
}
