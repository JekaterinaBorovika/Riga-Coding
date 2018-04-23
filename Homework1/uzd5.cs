using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class uzd5
    {
        public void VaiIrPara()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if(skaitlis % 2 == 0)
            {
                Console.Write("Ir pāra skaitlis");
            }
            else
            {
                Console.Write("Nav pāra skaitlis");
            }

            //4/2 = 2 atlikums = 0
            //5/2 = 2 atlikums = 1
        }
    }
}
