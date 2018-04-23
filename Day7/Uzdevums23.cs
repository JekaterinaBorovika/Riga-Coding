using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Uzdevums23
    {
        public void SkaitliPieci()
        {
            Console.Write("Cik skaitļus ievadīsi?");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits]; // izveido masīvu, kur ievadīsim skaitļus

            //1.cikls, kas aizpilda masīvu ar skaitļiem
            for (int i = 0; i < skaits; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }
            //2.cikls, kas atrod skaitļus "5" masīvā

            int skaitītājs = 0;
            foreach (int skaitlis in masivs)

            //for(int i = 0; i < masivs.Length; i++
            //{ int skaitlis = masivs[i]
            {
                if (skaitlis == 5)
                    
                {
                    skaitītājs++;
                }          
               
            }

            Console.WriteLine("Atrasti" + skaitītājs + " skaitļi 5.");
        }

    }
}
