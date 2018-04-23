using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class uzd4
    {
        public void GradiUzPretejo()
        {
            Console.WriteLine("Ievadiet grādus: ");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadiet mērvienību (F/C: ");
            string mervieniba = Console.ReadLine();
            mervieniba = mervieniba.ToUpper();//visi simboli, kas ir mērvienībā tiek pārveidoti par lielajiem

            double rezultats;

            //ja lietotājs ievada grādus pēc Fārenheita

            if(mervieniba == "F")
            //  if(mervieniba == "F" || mervieniba == "f")
            {
                rezultats = ((double)gradi - 32) * 5 / 9;
                Console.WriteLine(rezultats + "C");
            }
            else if(mervieniba == "C")// else ir tāpēc, ka ja pirmais variants nostrādā, otro nemaz nepārbauda
            {
                rezultats = (double) gradi * 9 / 5 + 32;
                Console.WriteLine(rezultats + "F");

            }

            else
            {
                Console.WriteLine("Nezināma mērvienība!");
            }
            
            public void IntervalaParbaude()
            {
                Console.Write("Ievadiet skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if (skaitlis >= -50)
                {
                    if (skaitlis <= 50)
                    {
                        Console.Write("Skaitlis ir atbilstošajā intervālā!");
                    }
                    else
                    {
                        Console.Write("Skaitlis ir atbilstošajā intervālā!");

                    }

                    else
                    {
                        Console.Write("Skaitlis ir atbilstošajā intervālā!");
                    }

                    //2.var.
                    if (skaitlis >= -50)
                    {
                        if (skaitlis <= 50)
                        {
                            Console.WriteLine("Skaitlis ir atbilstošjā intervālā!");
                            //return pārtrauc funkcijas tālāko izpildi
                            return;

                        }
                    }
                    Console.Write("Skaitlis nav atbilstošajā intervālā");

                    //3.variants

                    if (skaitlis >= -50 && skaitlis <= 50)
                    {
                    }

                }
            }

        }
    

