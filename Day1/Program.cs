using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(5);
            Console.WriteLine(4.6);
            //decimālskaitļa izvade
            Console.WriteLine("T");
            //simbola izvade
            Console.WriteLine('T');
            //nevar izvadīt vairākus simbolus ' pēdiņās (piemēram, 'hfdkkuhdft')
           

            int skaitlis1 = 9223;
            {
                Console.WriteLine(skaitlis1);
                Console.WriteLine("skaitlis1");

            }
            // jāievēro definēšanas secība - būs kļūda
            //ja nelieto pēdiņas, programma mēģina atrast vārdu iepriekšējā tekstā


            //int ir tips; mainīgā nosaukumā nevar lietot atstarpes (skaitlis1)
           


            SayHello();//jaunas funkcijas izsaukums
            OutputNumber();


            Console.ReadLine();
        

        }

        public static void SayHello()//funkcija bez rezultāta (void tips)
        {
            Console.WriteLine("Hello");
            
        }

        public static void OutputNumber()//funkcija bez rezultāta (void tips)
        {
            Console.WriteLine(7);
            SayHello();
            
        }

    }
}




///Console.ReadLine(); vajadzīgs, lai logs, kas izvada funkciju nepazūd
// vienas rindas komentārs

/*vairāku rindu
 komentārs
 komentārs*/
 

