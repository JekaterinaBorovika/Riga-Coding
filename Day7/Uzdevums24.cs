using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Uzdevums24
    {
        public void Masivi()
        {
            Console.Write("Cik skaitļus ievadīsi?");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits]; 

           
            for (int i = 0; i < skaits; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }


            int min = masivs [0];//foreach funkcija iziet visiem masīviem, nav svarīgi,kurš masīvs kvadrātiekavās tiks ieraksīts(var sākt procesu arī piem., no 3)
            int max = masivs [0];
            foreach(int skaitlis in masivs)
            {
                if (skaitlis < min)
                {
                    min = skaitlis;
                } 

                else if(skaitlis > max)
                {
                    max = skaitlis;
                }

            }


            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
        }

    }
}
