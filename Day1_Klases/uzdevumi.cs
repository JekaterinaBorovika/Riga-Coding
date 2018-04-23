using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    public class Uzdevumi
    {
        public static void Uzdevums1(string vards)
        {
            //izvada apvienotus teksta fragmentus
            //"Tavs vārds ir"
            //un mainīgā 'vārds' saturu
            Console.WriteLine("Tavs vārds ir " + vards);

        }

        public static void Uzdevums2(int skaitlis1, int skaitlis2)
        {

            Console.WriteLine(skaitlis1 + skaitlis2);
            // ja int vietā būtu string, tad izvadītos skaitlis, kas sastāv no abiem skaitļiem (5 un 6=>56)
        }




            
    

    }
}
