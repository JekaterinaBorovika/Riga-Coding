using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Udevums12
    {
        public void AtrumaAprekinasana()

        {
            Console.WriteLine("Ievadi attālumu: ");
            int attalums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi stundas:  ");
            int stundas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi minūtes:  ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi sekundes:  ");
            int sekundes = Convert.ToInt32(Console.ReadLine());

            //1. kopējais laiks sekundēs
            int kopejaisLaiks = sekundes + minutes * 60 + stundas * 60 * 60;
            //2. ātrums m/s
            double atrumsMs = (double)attalums / kopejaisLaiks;
            //3. attālums kilometros  
            double attalumsKm = attalums / 1000d;
            //4. ātrums km/h (attālums kilometros / laiks (60*60))
            double atrumsKmh = attalumsKm / kopejaisLaiks / (60 * 60);
            //5. attālums jūdzēs (attālums kilometros * 0.621371)
            double attalumsJ = attalumsKm * 0.621371;

            Console.WriteLine("Kopējais laiks (s) = " + kopejaisLaiks);
            Console.WriteLine("Ātrums (m/s) = " + kopejaisLaiks);
            Console.WriteLine("Attālums (km) = " + kopejaisLaiks);
            Console.WriteLine("Ātrums (km/h) = " + kopejaisLaiks);
            Console.WriteLine("Attālums (j) = " + kopejaisLaiks);
        }
    }
}
