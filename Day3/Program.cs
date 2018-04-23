using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Taisnsturis t1 = new Taisnsturis(3, 54);
            Taisnsturis t2 = new Taisnsturis(32, 99);

            t1.Laukums();
            t2.Laukums();*/

            Darbinieks darb = new Darbinieks();
            darb.Vards = "Peteris";
            darb.Dzivesvieta = new Adrese();
            darb.Dzivesvieta.Valsts = "Latvija";
            darb.Dzivesvieta.Pilseta = "Riga";
            darb.Dzivesvieta.Iela = "Rūpniecības iela";
            darb.Dzivesvieta.MajasNr = "15b";
            darb.Dzivesvieta.DzivoklaNr = 405;
            darb.AktualaNodala = new Nodala();
            darb.AktualaNodala.Nosaukums = "";
            darb.AktualaNodala.AtrasanasVieta = new Adrese();

            darb.IeprieksejaNodala = new Nodala();
            darb.IeprieksejaNodala.Nosaukums = "";
            darb.IeprieksejaNodala.AtrasanasVieta = new Adrese();






            darb.TeikumsViens();
            darb.TeikumsDivi();


            Console.ReadLine();

        }


        
    }
}
