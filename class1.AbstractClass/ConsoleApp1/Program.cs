using System;

namespace ConsoleApp1
{
    //farklı classlarda  aynı prop alanlarını tekrar tekrar kullanmanın anlamı yok bunu yerine temel sınıfta bunkları tanımlayıp temel sınıfı miras olarak alacağız.
    //peroson isimli temel sınıfımızı oluşturalım.


    //Abstrak Class:bazen temel sınıfta oluştruduğumuz bir methodun içini doldurmak istewmeyebiliriz. bunu abstak olarak belirtiyoruz
    //...Abstract class lar bizim için temel sınıftır.
    //...Ancak abstrak methodlar ancak abstrak sınıflar içinde tanımlanabilir.
    //...Kesin ama kesin kalıtım kullanan sınıflar bu abstrak olarak tanımlanan methodu override etmek zorundadır.
    //...vitrual de kesin override işlemi yoktu hatırlarsanız.
    //...Abstract sınıflardan nesne türetilemez.
    //...Temel sınıftaki işlemleri(örneğin methodu) miras alan sınıfta ezip kullanmak istiyorum ama temel sınıftan override ettiğim methodunda ezilmeden halini kullnmak istiyorum diyorsa
    //...Kullanmkak istediğiniz sınıfta base.methodismi; şeklinde çağırmalısın.
    //..Aşağıdaki açıklamalar kalıtım dersinden kalan açıklamalardır Bunu ayrıca belirtmek istedim.
    abstract class person
    {

        public int id { get; set; }
        public string Name { get; set; }


        public person(int _id, string _name)
        {
            this.id = _id;
            this.Name = _name;
            Console.WriteLine("Person nesnei oluşturuldu");
        }

        //person bilgilerini ekrana yazdıran methodu oluşturalım
        public abstract void persondetais();
       

    }

    class student : person
    {
        //iyi ama studentin kendine özel alanları varsada this ile veri eşlemsini yapacağız ama base içine göndermeyeceğiz
        public int studentNbumber { get; set; }

        //parametresi olmayan bir cantraktır oluşturmak istersek hate veriri neden çünkü;  student kanstrakterından önce person kantrakterı oluşturulacaktır ve orda da 2 parametre bekliyor.
        //person kantrakter içindeki parametrelerin aynılarını student kantrakter parametre alanına ekliyoruz.
        //pertson kanstrakterı içinde yaptığım değer atamalarını burdada yapmama gerek yok bunun yerine :base(parametre isimleri) keyvordu ile temel sınıfın kantsrakterına göndereceğiz.
        public student(int studentNbumber, int _id, string _name) : base(_id, _name)
        {
            
            Console.WriteLine("Person nesnei oluşturuldu");
        }

        //person bilgilerini ekrana yazdıran methodunu buraya kopyaladım ancak buraya ekleyecceğim methot temel sınıftaki methodu ezmiş olmalı bunun içinde temel sınıftaki ilgili methodu virtual olarak işaretlemeliyim
        //ve burada da virtual olarak işaretlediğim metgodu ovveride etmeliyim
         
        public override void persondetais()
        {
           
            Console.WriteLine($"student-Number:{this.studentNbumber} student-id:{this.id} student-Name:{this.Name}");
        }

    }


    //şimdi birdteacher clas sı oluşturalım ve miras alalım
    class teacher : person
    {
        public string bransh { get; set; } //teacher aait özel alanu

        public teacher(int _id, string _name, string _bransh) : base(_id, _name)
        {
            this.bransh = _bransh;

        }

        public override void persondetais()
        {
            Console.WriteLine($"Teacher-id:{this.id} Teacher-Name:{this.Name}, Teacher-Bransh:{this.bransh}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //miraas alma olayımız gerçekleşmiş mi bir kontrol edelim
            
            var s1 = new student(1260130, 002, "Gökçe Altun");
            var t1 = new teacher(003, "Emin Altun", "Sınıf öpretmeni");
           
            s1.persondetais();
            t1.persondetais();

        }
    }
}
