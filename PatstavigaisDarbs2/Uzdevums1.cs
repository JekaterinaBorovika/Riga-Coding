using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatstavigaisDarbs2
{
    public class Uzdevums1
    {
        public void SkaitluIevade()
            
            
                  
        {
                      
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

          


            int sksumma = skaitlis1 + skaitlis2;
            int skstarpiba = skaitlis1 - skaitlis2;
            int skreizinajums = skaitlis1 * skaitlis2;


            Console.WriteLine("Skaitļu summa ir: " + sksumma);
            Console.WriteLine("Skaitļu starpība ir: " + skstarpiba);
            Console.WriteLine("Skaitļu reizinājums ir: " + skreizinajums);

            {
                if(skaitlis1 > skaitlis2)
                {
                    Console.WriteLine("Lielākais skaitlis: " + skaitlis1);
                }
            }
            

            if(skaitlis1 < skaitlis2)
            {
                Console.WriteLine("Mazākais skaitlis: " + skaitlis2);
            }








        }

    }
}

