using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    public class Uzdevumi
    {
        public void VienadiSkaitli()
        {
            //1.paprasa ievadīt skaitli1
            Console.Write("Ievadi pirmo skaitli: ");
            //2.nolasa ievadīto vērtību
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            //3.paprasa ievadīt skaitli2
            Console.Write("Ievadi otro skaitli: ");
            //4.nolasa ievadīto vērtību
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            //5.salīdzinām, vai skaitļi ir vienādi
            if (skaitlis1 == skaitlis2)
            {
                Console.WriteLine("Skaitļi ir vienādi");

            }

            else
            {
                Console.WriteLine("Skaitļi nav vienādi");
            }
        }
           
            public void Menesi()
            {
                Console.WriteLine("Ievadi mēneša nosaukumu: ");
                string menesis = Console.ReadLine();

            if (menesis == "Feb")
            {
                Console.WriteLine("28 dienas");


            }
            else if (menesis == "Apr")

            {
                Console.WriteLine("30 dienas");
            }

            else if (menesis == "Jūn")
            {
                Console.WriteLine("30 dienas");
            }

            else if (menesis == "Sep")
            {
                Console.WriteLine("30 dienas");

            }
            else if (menesis == "Nov")
            {
                Console.WriteLine("30 dienas");
            }
            else if (menesis == "Jan" || menesis == "Mar" || menesis == "Mai" || menesis == "Jul" || menesis == "Aug" || menesis == "Okt" || menesis == "Dec")
            {
                Console.WriteLine("31 dienas");
            }
                //vai arī var apvienot:

                //else if(menesis == "Apr" || menesis == "Jūn" || menesis == "Sep" || menesis == "Nov"
            }
           

            
        

    }
}
