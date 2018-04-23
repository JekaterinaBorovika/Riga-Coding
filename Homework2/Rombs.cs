using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Rombs
    {

        public void Rezgis()
        {
            Console.WriteLine("Ievadi rindu skaitu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //cikls, kas attēlo N rindas

            for (int rinda = 1; rinda <= n; rinda++)
            {
                for (int kolona = 1; kolona <= n; kolona++)
                {
                    Console.Write("*");
                }
                //pārejam jaunā rindā, kad ir izvadīti N simboli
                Console.WriteLine();//katru darbību pārnes jaunā rindā
            }
        }
    }
}
