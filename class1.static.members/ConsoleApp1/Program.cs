using System;

namespace ConsoleApp1
{
    //statik sınıflar içindeki statik üyeler nedir bunu ele alacağız
    //-İşlemimi sınıf üzerinden halledebiliyorsam nesne oluşturmama gerek yok statik membersta
    //-okul örneğinde olduğu gibi öğrenci ve öğretmen classları içinde yer alan prop alanlarda olduğu gibi,
    //aynı alanları tüm classlar içinde ayrı ayrı tekrar eden tarzda yazmama gerek yok
    //-Miras alacağın class içinde bunları oluşturman yeterli oradan set edeceksin
    //-Statik alanların kontrolü tamamen class üzeirnden olacak - nesneler üzerinden değil
    //-static class tanımladığımız gibi statik prop yada methodlarda tanımlayabiliriz. 


    //***class ı direk statik yapsak insis üyeler hata veriri yani statik olmayan prop yada methodlar hata verir ve nesne türetemeyiz
    //***Yani insıs class içinde statik prop yada methodtlar oluşturabilriken statik bir sınıfta insıst statik olamyan prop yadda methodlar oluşturamayız.
    class student
    {
        public int studentNumbner { get; set; }
        public string studentName { get; set; }

        //Bu noktada şimdi buraya statik proplar ekleyelim. bu statik proplar classa
        //özel class üzerinden ulaşabiliriz. türettiğimiz nesneler üzerinden ulaşamayız
        public static string school = "Seşçuk üniversitesi";
        public static string adress = "Bosna mah. No:42/1 selcuklu konya";




        //yapıcı methodumuızu tanımlayalım
        public student(int _studentNumber, string _studentName)
        {
            this.studentNumbner = _studentNumber;
            this.studentName = _studentName;
        }

        public void studentDetails()
        {
            Console.WriteLine($"öğrenci No:{this.studentNumbner} öğrenci Adi:{this.studentName}");
        }

        //bir methot daha olşuturalıum ve buı methodta statik propları ekrana yazdırsın
        public static void staticdetails()
        {
            Console.WriteLine($"School:{school} Adress:{adress}");
        }
    }


    //gelin burda yardımcı methodların barındığı statik bir class oluşturalım
    static class hepermethosts
    {
        public static string karakterDuzelt(string veri) //karakter düzelt diye bir method tanımladım
        {
            return veri.Replace(" ","/").Replace("e","E");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            //ilgili cclasstan nesneler(öğrenciler) türetelim
            var student1 = new student(1260,"Recep Altun");
            var student2 = new student(1261, "Gökçe Altun");
            var student3 = new student(1262, "Atakan Altun");

            student1.studentDetails();
            //static alanları staticalanalrı ekrana yazdıraccak methodu kullanarak yazdıralım
            student.staticdetails();


            //static hepermethosts class i için vir _veri türetelim bu class içinde bulunana karakterDüzelt methoduna da direkt class üzeirnden erişeceğiz
            string veri = "Recep Altun";
            Console.WriteLine(hepermethosts.karakterDuzelt(veri));
        }
    }
}
