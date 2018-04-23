using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Auto//klases nosaukums (ir vienāds ar konstruktora nosaukuma)
    {
        public Auto()//konstruktors - funkcijai nav rezultāta tipa (void) un !!!nosaukums sakrīt ar klases nosaukumu!!!
        {
            this.Marka = "Nezināms";
            this.Krasa = "Nezināms";
        }

        public string Marka;//; nozīmē, ka tā ir tikai īpašība, ja būtu iekavas, tad vajadzētu definēt parametrus
        public string Krasa;

        public void Info()//šeit sākas funkcija
        {
            Console.WriteLine("Auto marka ir " + this.Marka); //"this" pasaka, ka mainīgais nav jāmeklē...?
            Console.WriteLine("Auto krāsa ir " + Krasa);

        }
    }
}
