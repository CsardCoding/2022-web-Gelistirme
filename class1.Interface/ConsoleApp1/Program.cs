using System;

namespace ConsoleApp1
{

    //interface Asılnda var sayılan olarak abstrak bir yapıdır.
    //...interface de bir classımız var ve bu clas daha önceden belirttiğimiz method ve prop lara uyacağını gösteriyor. bunlara bağlı kalacak bir sözleşme niteliği taşıyor bu bakımdan
    //... artık kanstrakterımızı Iperosn içine ekleyemeyiz.
    //...Iperson içinde yeri bir alan yada method eklediğimde diğer classlarda kalıtım yaptığım nokta hata verir ve ctr + enter basıp ara birimi uygula dediğimizde oluşturulan yeni özellikler diğer classlara aktarılır.
    //...Yeni bir class daha tanımlasam ve bu class ta Iperson dan miras alsa o zaman yeni oluşturduğum classın kullanmayacağı özelliklerde kalıtım nedeniyle gelir.
    //......Bu noktada bir Interface daha tanımlayacağım ve ilgili özellikleir bu Interface içine alacağım,
    //......Eğer ki oluşturulan bir cclass her iki interface içindeki özellikleri de kullanmak isterse kalıtım yerinde virgülle hangi interfaceleri miras olarak alacaksa virgülle ayırarak buraya yazıyoruz.
    

    //interfdace  tanımlayalım
    interface Iperson //Iperson olarak isim veriyorum ki interface olduğunu anlayabileyim.
    {
        //Alanlarımı tanımlıyorum
        string adısoyadı { get; set; }
        string adress { get; set; }
        string departman { get; set; }



        //bir tane method tanımlayalım boş olsun yani abstact
        void bilgi();

    }

    class yonetici : Iperson //Ipersondan miras aldı
    {
        public string adısoyadı { get; set; }
        public string adress { get; set; }
        public string departman { get; set; }

        //kanstrakterımı burya ekliyorum ****Burası önemli bu nokta kalıtım ile gelmiyor.
        public yonetici(string _name, String _adress, string _departman)
        {
            this.adısoyadı = _name;
            this.adress = _adress;
            this.departman = _departman;
        }

       

        void Iperson.bilgi()
        {
            Console.WriteLine($"{this.adısoyadı} isimli personel {this.departman} Yöneticidir.");
        }
    }

    class isci : Iperson
    {
        public string adısoyadı { get; set; }
        public string adress { get; set; }
        public string departman { get; set; }

        //kanstraktırımı burayada oluştrudum
        public isci(string _name, String _adress, string _departman)
        {
            this.adısoyadı = _name;
            this.adress = _adress;
            this.departman = _departman;
        }

        

        void Iperson.bilgi()
        {
            Console.WriteLine($"{this.adısoyadı} isimli personel {this.departman} İşcidir.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Bu alanın hatasız çalışmasını istiyorsak isci ve yönetici içinde oluşturulan kantstrakterı silmeliyim
             
            //ilgili sınıflardan bir nesne türetelim
            Iperson y1 = new yonetici() {adısoyadı="Recep Altun", adress="Konya / Selçuklu", departman="Full Stac Developer"};
            Iperson i1 = new iscic() {adısoyadı="Emine Altun", adress="Konya/Selçuklu", departman="Halı Paketleme"};
            //yukarda görüldüğü gibi Iperson diyerek nesne türettim peki bu ne işime yarar
            //...Şöyleki yararını gösteriyorum.
            
            var personeller = new Iperson[2];
            personeller[0] = new iscic();
            personeller[1] = new yonetici();
            personeller[3] = new iscic() {adısoyadı="Ayse Altun", adress="Konya / Doğanhisar",departman="Battaniye Paketleme"}; //şeklinde kolayca nesne üretmemize yarar
            
             */


            //kanstrakter ile birlikte nesne üretme şeklim artık değişti kantrakterı kullanarak nesne üreteyim

            var personeller = new Iperson[3];
            personeller[0] = new yonetici("Recep Altun","Konya/Meram","Bilgi İşlem");
            personeller[1] = new isci("Emine Altun", "Konya/Meram", "Halı Dokuma");
            personeller[2] = new isci("Ayşe Altun", "Konya/Doğanhisar", "İplik Eğirme");

            foreach (var personel in personeller)
            {
                personel.bilgi();
            }
        }
    }
}
