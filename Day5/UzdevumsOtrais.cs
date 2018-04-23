using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
   public class UzdevumsOtrais
    {
        public void Modinatajs()
        {
            Console.WriteLine("Ievadi dienu: ");
            string diena = Console.ReadLine();
            Console.WriteLine("Vai ir atvaļinājums(jā/nē: ");
            string irAtvalinajums = Console.ReadLine();

            if (diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "P")
               
            {
                if(irAtvalinajums == "Jā")
                {
                    Console.WriteLine("10:00");
                }
                else
                {
                    Console.WriteLine("07:00");
                }
                
            }

            else if(diena == "Se" || diena == "Sv")
            {
                if (irAtvalinajums == "Jā")
                {
                    Console.WriteLine("Off");
                }
                //īsāks pieraksts - Console.WriteLine(irAtvalinajums == "Jā" ? "Off" : "10:00";
                else
                {
                    Console.WriteLine("Neatļauta vērtība!");
                }
            }
        }
    }
}
