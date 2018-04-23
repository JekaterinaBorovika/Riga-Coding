using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
   public class Program
    {
       public static void Main(string[] args)
            //"Main" galvenais ieejas punkts aplikācija
        {
            Uzdevumi uzdevumi = new Uzdevumi();//izveido jaunu objektu no klases "Uzdevumi"

            //zemāk tiek izsauktas objekta funkcijas
            /* uzdevumi.Reizinajums(1, 2, 3);
             uzdevumi.SkaitluMaina(5, 6);
             uzdevumi.Aprekini(5, 2);
             uzdevumi.IevadiVardu();
             uzdevumi.GraduParversana();*/

            /*  Auto auto = new Auto();
              auto.Krasa = "Melns";
              auto.Marka = "Audi";
              auto.Info();

              Auto vw = new Auto();
              vw.Krasa = "Zaļš";
              vw.Marka = "VW";
              vw.Info();


              Auto nezinams = new Auto();//izveidojot jaunu objektu, tiek izsaukta arī funkcija
              nezinams.Info();*/

            Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkans";
            /*kv1.MalasGarums = 4;
            kv1.KrasasIzvade();*/
            //ja zemāk definē krāsu (melns) un garumu (5), tad divas augšējās rindiņas vairs nav vajadzīgas
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums);
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Kvadrats kv2 = new Kvadrats("melns", 5);//šeit nodefinējam krāsu un malas garumu iekavās, līdz ar to augšā divas rindiņas vairs nav vajadzīgas (kv1.MalasGarums = 4 ...)
            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());



            Console.ReadLine();//funkcija, kas patur atvērtu logu, līdz nospiež ENTER



        }
    }
}
