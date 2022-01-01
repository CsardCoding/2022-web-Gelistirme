using System;

namespace ConsoleApp1
{
    class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }
        public bool otomatik { get; set; }

        //bu arabaya class ına hizmet eden methodlarımız olsun
        public void start()
        {
            Console.WriteLine("Araç Çalıştırıldı");
        }
        public void stop()
        {
            Console.WriteLine("Araç Stop edildi");
        }

        public  void hızlan()
        {
            Console.WriteLine("Araç Hızlanıyor");
        }
        public void yavasla()
        {
            Console.WriteLine("Araç yavaşlıyor");
        }


        //kaydını girdiğimiz araçları ekrana bastıran methodsu oluşturalım
        public void ekranabas()
        {
            Console.WriteLine($"MARKA:{this.marka} MODEL:{this.model} RENK:{this.renk} VİTES:{this.otomatik}");
        }

        // tüm bu işlemleri metotları seçmemize yarayacak bir menu methodu oluşturalım
        public void menu()
        {
            string c="";
            do
            {
                Console.WriteLine("ne yapmak istiyorusun?__1-Start, 2-Hızlanıyor, 3-Yavaslıyor, 4- Stop");
                c = Console.ReadLine();


                switch (c)
                {
                    case "1":
                        this.start();
                        break;
                    case "2":
                        this.hızlan();
                        break;
                    case "3":
                        this.yavasla();
                        break;
                    case "4":
                        this.stop();
                        break;
                    case "0":
                        Console.WriteLine("menuden ayrıldınız");
                        break;
                    default:
                        Console.WriteLine("yanlış seçim");
                        continue;
                }

                

            } while (c!="0");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Araba car1 = new Araba() { marka = "OPEL", model = "CORSA", renk = "KIRMIKZI", otomatik = true };
            car1.menu();
            car1.start();
            car1.hızlan();
            car1.yavasla();
            car1.stop();

            //araba nesnesinden nesneler uretelim.

            Console.WriteLine("kaç araç kaydı yapmak istiyorsunuz?");
            var adet = int.Parse(Console.ReadLine());
            Araba[] arabalar = new Araba[adet];

            int i = 0;

            Araba car;

            do
            {
                car = new Araba();

                Console.WriteLine("Araç markasını giriniz?");
               car.marka= Console.ReadLine().ToString();

                Console.WriteLine("Araç Modelini giriniz?");
                car.model = Console.ReadLine().ToString();

                Console.WriteLine("Rengini giriniz?");
                car.renk = Console.ReadLine().ToString();

                Console.WriteLine("Araç vitesini  giriniz?");
                car.otomatik= bool.Parse(Console.ReadLine());

                arabalar[i] = car;
                i++;



            } while (i!=adet);


            foreach (var item in arabalar)
            {
                 Console.WriteLine($"MARKA:{item.marka} MODEL:{item.model} RENK:{item.renk} VİTES:{item.otomatik}");
                
            }

            

        }
    }
}
