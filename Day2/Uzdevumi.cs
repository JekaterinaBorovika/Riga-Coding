using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Uzdevumi
    {
        public void Reizinajums(int skaitlis1, int skaitlis2, int skaitlis3)
        {
            Console.WriteLine(skaitlis1 * skaitlis2 * skaitlis3);
        }
        public void SkaitluMaina(int sk1, int sk2)
        {
            Console.WriteLine("Sk1=" + sk1);//5
            Console.WriteLine("Sk2" + sk2);//6

            int sk1VecaVertiba = sk1;
            sk1 = sk2;
            sk2 = sk1VecaVertiba;

            Console.WriteLine("Sk1 = " + sk1);//6
            Console.WriteLine("Sk2 = " + sk2);//5
        }
        public void Aprekini(int sk1, int sk2)
        {
            Console.WriteLine(sk1 + sk2);
            Console.WriteLine(sk1 - sk2);
            Console.WriteLine(sk1 * sk2);
            double dalijums = (double)sk1 / sk2;
            Console.WriteLine(dalijums);
            // vai arī 2.var. Console.WriteLine((double)sk1/sk2);
            Console.WriteLine(sk1 % sk2);
        }

        public void IevadiVardu()//tiek definēta jauna funkcija "IevadiVardu", šī funkcija ir bez paramentriem, tā arī neatagriež vērtību
        {

            Console.Write("Ievadi vārdu: ");//šis teksta fragments tiks attēlots, izvada tekstu un kursors paliek tajā pašā rindā
            string vards = Console.ReadLine();//nolasa ievadīto tekstu

            Console.WriteLine("Tevi sauc " + vards);//teksta izvade, kur kursors pāriet nākamajā rindā

            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());//pārveido ievadīto tekstu uz veselu skaitli
         
            Console.WriteLine("Skaitlis ir " + skaitlis);//izvada rezultātu

            
        }

        public void GraduParversana()
        {
            Console.Write("Ievadi grādus pēc Celsija: ");
            string vertiba = Console.ReadLine();
            int gradi = Convert.ToInt32(vertiba);
            //vai:
            //int gradi = Convert.ToInt32(Console.ReadLine());
            double gradiF = gradi * 9 / 5 + 32;
            int gradiK = gradi + 273;

            Console.WriteLine("Pēc Fārenheita: " + gradiF);
            Console.WriteLine("Pēc Kelvina: " + gradiK);
        }


    }
}
