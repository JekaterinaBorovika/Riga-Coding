using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevums22
    {
        public void DarbibasArSkaitliem()
        {
            
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi darbību: ");
            string darbiba = Console.ReadLine();

            double rezultats;


            switch (darbiba)
            {
                case "+":
                    rezultats = skaitlis1 + skaitlis2;
                    break;

                case "-":
                    rezultats = skaitlis1 - skaitlis2;
                    break;

                case "*":
                    rezultats = skaitlis1 * skaitlis2;
                    break;

                case "/":
                    if(skaitlis2 == 0)
                    {
                        Console.WriteLine("Darbība nav atļauta!");

                        return;
                    }
                    rezultats = (double) skaitlis1 / skaitlis2;
                    break;
                default:
                    Console.Write("Neatļauta darbība!");
                    return;
            }



        }
    }
}
//try funkcija - pārbauda kļūdas