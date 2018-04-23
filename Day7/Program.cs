using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Program
    {
       public static void Main(string[] args)
        {
            /*Uzdevums23 Skaitli2 = new Uzdevums23();
            Skaitli2.SkaitliPieci();
            Uzdevums20 valsts = new Uzdevums20();
            valsts.Valstis();*/
            Uzdevums22 darbiba = new Uzdevums22();
            darbiba.DarbibasArSkaitliem();
            Uzdevums24 minmax = new Uzdevums24();
            minmax.Masivi();


            Console.ReadLine();

        }

        public static void Piemers()
        {
            Console.WriteLine("Ievadi dienu: ");
            string diena = Console.ReadLine();

            switch (diena)
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "Pk":
                    Console.WriteLine("Ir darbdiena.");
                    if(diena == "Pk")
                    {
                        Console.WriteLine("Piektdiena!");
                    }
                    break;//zars beidzas, beidzas pirmais nosacījums
                case "S":
                case "Sv":
                    Console.WriteLine("Ir brīvdiena.");
                    break;//beidzas otrais nosacījums
                default:
                    Console.WriteLine("Nezināma diena.");
                    
                    break;
            }

           
        }

                
    }
}
