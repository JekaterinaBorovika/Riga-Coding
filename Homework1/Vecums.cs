using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
   public class Vecums
    {
        public void TavsVecums()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

           if (skaitlis > 18)
            {
                Console.WriteLine("persona ir pilngadīga");
            }

            else
            {
                Console.WriteLine("persona ir nepilngadīga");
                
            }

        }
      
    }
}
