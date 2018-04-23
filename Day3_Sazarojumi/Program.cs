using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevumi uzd = new Uzdevumi();
            //uzd.VienadiSkaitli();
            uzd.Menesi();




            Console.ReadLine();
        }



        public void Piemers()
        {
            int skaitlis = 99;

            //pārbaudes rezultāts - vai skaitlis ir vienāds ar 5
            bool vaiIrVienadsArPieci = skaitlis == 5;

            //ja skaitlis ir lielāks nekā 5

            if (skaitlis > 5)
            {
                Console.WriteLine("Skaitlis ir lielāks par 5");

            }//ja skaitlis ir vienāds ar pieci
            else if (vaiIrVienadsArPieci)
            {
                Console.WriteLine("Skaitlis ir vienāds ar 5");
            }
            //citadi...
            else
            {
                Console.WriteLine("Skaitlis nav lielāks par 5");
            }

            Console.ReadLine();
        }
    }
}
