using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class UzdevumsTresais
    {
        public void Sodi()
        {
            /*Console.Write("Vai Tev ir dzimšanas diena (jā/nē): ");
            string Atbilde = Console.ReadLine();

            Console.WriteLine("Ievadi ātrumu: ");
            int Atrums = Convert.ToInt32(Console.ReadLine());

            if (Atbilde == "j")
            {
                if(Atrums <= 65)
                {
                Console.WriteLine("nav soda");
                }
                
            
            else if(Atrums >= 66 && Atrums <= 85)
            {
                Console.WriteLine("neliels sods");
            }

            else if(Atrums > 85)
            {
                Console.WriteLine("liels sods");
             
            }

            }


           else if (Atbilde == "n")
            {
                if (Atrums <= 60)
                {
                Console.WriteLine("nav soda");
                }
                
            

            else if (Atrums >= 61 && Atrums <= 80)
            {
                Console.WriteLine("neliels sods");
            }

            else if (Atrums > 80)
            {
                Console.WriteLine("liels sods");

            }
            }*/


            

            Console.WriteLine("Ievadi ātrumu: ");
            int atrums = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vai Tev ir dzimšanas diena (jā/nē): ");
            string irDzD = Console.ReadLine();

            if (irDzD) == "Jā"){
                atrums = atrums - 5;
                //īsāks pieraksts ir:  atrums -=5;
            }

            if(atrums > 80)
            {
                Console.WriteLine("2 - liels sods");
            }
            else if(atrums < 60 && atrums <= 80)
            {
                Console.WriteLine("1 - mazs sods");
            }
            else
            {
                Console.WriteLine("0 - nav soda");
            }
        }
            
        
    }
}
