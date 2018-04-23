using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class uzdevumsPiektais
    {
        public void Stop13()
        {
            int summa = 0;

            while (true)
            {
                Console.WriteLine("Ievadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if(skaitlis == 13)
                {
                    break;//darbība tiek automātiski pārtraukta, pārtrauc ciklu, break strādā tikai uz vienu ciklu (iekšēju)
                }
                else
                {
                    summa += skaitlis;
                    //summa = summa + skaitlis;
                }
            }

            Console.WriteLine("Summa ir " + summa);
        }

    }
}
//return pārtrauc visu funkciju, return 'izmestu' ārā no visiem cikliem