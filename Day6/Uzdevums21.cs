using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Uzdevums21
    {
        public static void ApgrieztsMasivs()
        {
            //1.paprasām lietotājam ievadīt, cik skaitļus viņš ievadīs
            //2.paprasām viņam ievadīt N skaitļus
            Console.WriteLine("Cik skaitļus ievadīsi?");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] skaitli = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ievadi " + i + ". skaitli");
                skaitli[i] = Convert.ToInt32(Console.ReadLine());//liekam pozīcijā i, jo tas mums ir no nulles līdz i
            }

            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine(skaitli[i]);
            }
        }
    }
}
