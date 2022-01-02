using System;

namespace ConsoleApp1
{

    class question
    {
        public question(string _text, string[]_choise, string _answer)
        {
            this.text = _text;
            this.choies = _choise;
            this.answer = _answer;

        }
        public string text { get; set; }
        public string[] choies { get; set; }

        public string answer { get; set; }

        //cevabı kontrol eden bir methot tanımlayalım
        public bool controlanswer(string _answer)
        {
            //burada if blokları kullanmadım ne kadar cok if bloğu kullanırsanız programlarınız oop (nesne tabanlı programlamadan) uzaklaşır müdahale etmek zorlaşır.
            return this.answer.ToLower() == _answer.ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //oluşturduğumuz class uzerinden soru tanımlayalım
            var soru1 = new question("hangisi başkent?", new string[] { "ankara", "adana", "istanbul", "izmir" }, "ankara");
            var soru2 = new question("hangisi meyvedir?",new string[]{"domates","elma","patlıcan","mamrul"},"elma");

   


            //sorularımız kuıllanmıcı karşısına soru 1 soreu 2 şeklinde çıkarmka istersek

            var sorular = new question[] {soru1, soru2};
            //foreach ile sorular dizisi üstünde dönelim
             var index = 1;

            foreach (var item in sorular)
            {
                Console.WriteLine($"soru-{index}:{item.text}");
                //cevaplar dizisini oluşturup ekranda gösterelim
                foreach (var sık in item.choies)
                {
                    Console.WriteLine($"A:{sık} B:{sık} C:{sık} D:{sık}");
                    break;
                }

                var getcevap = Console.ReadLine();
                Console.WriteLine(item.controlanswer(getcevap));
                index += 1;
            }

            
            
            
        }
    }
}
