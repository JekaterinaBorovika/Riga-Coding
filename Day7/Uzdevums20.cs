using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevums20
    {
        public void Valstis()
        {
            Console.WriteLine("Ievadi valsti: ");
            string valsts = Console.ReadLine();

            switch (valsts.ToLower())
            {
                case "igaunija":
                    Console.WriteLine("Tallina");
                    break;
                case "somija":
                    Console.WriteLine("Helsinki");
                    break;
                case "ukraina":
                    Console.WriteLine("Kijeva");
                    break;
                case "zviedrija":
                    Console.WriteLine("Stokholma");
                    break;
                case "krievija":
                    Console.WriteLine("Maskava");
                    break;
                default:
                    Console.Write("Galvaspilsēta nav zināma!");
                    break;
            }
        }
    }
}
