using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Darbinieks
    {
       public Adrese Dzivesvieta;//salikts tips (Adrese) - var būt gan vārdi, gan skaitļi

       public string Vards;
       public string Uzvards;
       public string DzGads;
       public string Epasts;
       public string Talrunis;
       public Adrese Dzivesvieta;
       public Nodala AktualaNodala;
       public Nodala IeprieksejaNodala;

       

       public void TeikumsViens()
        {
            Console.WriteLine("Mani sauc " + Vards + ", es dzīvoju " + Dzivesvieta.PilnaAdrese());

      

        }
        public void TeikumsDivi()
        {

            //Mani sauc {Darbinieks:Vards},
            //un es pārgāju
            //uz { Aktuala nodala:Nosaukums}
            //no { Iepriekseja nodala:Nosaukums}
            //kura atradās { Iepriekseja nodala:Atrasanas vieta}

            Console.WriteLine("Mani sauc " + Vards
                + "un es pārgāju uz " 
                + AktualaNodala.Nosaukums
                + "no"
                + IeprieksejaNodala.Nosaukums
                + "kura atradās " 
                + IeprieksejaNodala.AtrasanasVieta.PilnaAdrese());
        }
    }
}
