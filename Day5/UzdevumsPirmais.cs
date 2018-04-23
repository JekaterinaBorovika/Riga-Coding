using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class UzdevumsPirmais
    {
        public void Virkne()
        {
            Console.WriteLine("Ievadi skaitli N: ");
            int skaitlisN = Convert.ToInt32(Console.ReadLine());

            for (int skaitlis = skaitlisN; skaitlis >= 1; skaitlis = skaitlis - 1)
            {
                Console.WriteLine("skaitlis =" + skaitlis);
                Console.ReadLine();

            }
        }
    }
}
