using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class UzdevumsCeturtais
    {
        public void FizzBuzz()
        {
            Console.WriteLine("Ievadi skaitli1: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi skaitli2: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sk1; i <= sk2; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)// jānovieto pirms visām pārbaudēm!!!
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }


                Console.Write(", ");
            }
        }



    }
}
