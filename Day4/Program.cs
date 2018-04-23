using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Piemeri();
            Uzdevumi GadaSk = new Uzdevumi();
            GadaSk.Gadi();
            Console.ReadLine();
            uzdevums16 Ievade = new uzdevums16();
            Ievade.SkaitluIevade();
            Uzdevums17 rezgis = new Uzdevums17();
            rezgis.Rezgis();

            Console.ReadLine();


        }
        public static void Piemeri()
        {
            //i++ jeb i = i + 1
            //i sākotnējā vērtība = 40
            // pildīt tik ilgi, kamēr i ir mazāks vai vienāds ar 50
            //palielināt i par 2
            for (int i = 40; i <= 50; i = i + 2)
            {
                Console.WriteLine("i = " + i);
                Console.ReadLine();

            }
            int n = 10;
            while(n >= 0)
            {
                Console.WriteLine("n = " + n);
                n = n - 3;

            }

            bool turpinat = true;
            while (turpinat)
            {
                Console.Write("Ivadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vai turpināsi ievadi (j/n)?");
                string atbilde = Console.ReadLine();

                if(atbilde == "j")
                {
                    turpinat = true;
                }
                else
                {
                    turpinat = false;
                }
            }
        }
        /*{
            Udevums12 aprekins = new Udevums12();
            aprekins.AtrumaAprekinasana();
            Console.ReadLine();

        }*/

        


         
        
    }
}
