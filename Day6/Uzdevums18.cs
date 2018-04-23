using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Uzdevums18
    {
        public static void Trijsturis()
        {

       Console.WriteLine("Ievadi skaitu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            //cikls, kas attēlo N rindas
            for (int rinda = 1; rinda <= skaitlis; rinda++)
            {
                /*for (int kolona = 1; kolona <= rinda; kolona++) uzrakstīs otrādāk!!! */ 
                   for (int kolona = skaitlis - rinda; kolona >=1; kolona--)
                {
                Console.Write(kolona);
                }
    //pārejam jaunā rindā, kad ir izvadīti N simboli
    Console.WriteLine();/*peles labā poga uz funkcijas nosaukuma, izvēlās "Go to Definition", 
                var redzēt, kāda funkcija ir, kādi parametri, vai ir statiska vai nav..*/
            }
        }
        
            

        
    }
}
