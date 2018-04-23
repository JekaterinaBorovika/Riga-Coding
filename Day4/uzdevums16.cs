using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class uzdevums16
    {
        public void SkaitluIevade()
        {
            //1.paprasa ievadīt skaitu N
            Console.WriteLine("Ievadi N skaitu: ");
            //2.nolasa ievadīto vērtību
            int n = Convert.ToInt32(Console.ReadLine());
            //3.cikliski prasa ievadīt N vērtības
            int summa = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("Ievadi " + i + ". skaitli: ");

                //3.1.nolasa katru ievadīto vērtību
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa = summa + skaitlis;
                // vai arī:
                // summa += skaitlis;
            }
            

            //4.aprēķina ievadīto skaitļu kopsummu
            Console.WriteLine("Summa ir " + summa);
            //5.aprēķina ievadīto skaitļu vidējo vērtību
            Console.WriteLine("Vidējā vērtība ir " + (summa / n));

        }
    }    
}
