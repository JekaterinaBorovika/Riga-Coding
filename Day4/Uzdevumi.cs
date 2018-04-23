using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Uzdevumi
    {
        public void Gadi()
        {
            //1.paprasa ievadīt gada skaitli
            Console.WriteLine("Ieraksti gada skaitli: ");
            //2.nolasa ievadīto skaitli
            int gadsNo = Convert.ToInt32(Console.ReadLine());
            //3.izvada visus gadskaitļus no ievadītā līdz 2018
            for(int gads = gadsNo; gads <= DateTime.Now.Year; gads++)

                //lai esošais gads nav jāraksta ar roku, tad jāizmanto - DateTime.Now.Year
            {
                Console.WriteLine(gads + ". gads");


            }
        }
    }
}
