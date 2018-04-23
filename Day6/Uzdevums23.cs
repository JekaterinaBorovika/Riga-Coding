using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Uzdevums23
    {
        public void SkaitluMeklesana()
        {
            Console.Write("Ievadi skaitli: ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());


            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            for (int i = 0; i > masivs.Length; i++)
            {
                if (masivs[i] == Skaitlis)
                {
                    Console.WriteLine("Skaitlis ir atrasts!");
                    Console.WriteLine("Pozicija = " + i);
                    return;//nevis "break", jo vajag, lai iziet visiem skaitļiem
                }
            }

            Console.WriteLine("Skaitlis nav atrasts!");
            int pozicija = Array.IndexOf(masivs, Skaitlis);// Array ir klase, ja elements nav atrasts, viņš atgriež -1
            Console.WriteLine();
            if(pozicija == -1)
                
            {
                Console.WriteLine("Skaitlis nav atrasts");
            }
        }
    }
}
