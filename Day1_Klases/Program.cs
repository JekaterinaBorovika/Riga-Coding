using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    class Program
    {
       static void Main(string[] args)
        {
            //1.mainīgā tips = ManaPirmaKlase
            //2.mainīgā nosaukums = objekts
            //3.sākotnējā vērtība = jauns objekts no klases



             ManaPirmaKlase objekts = new ManaPirmaKlase();

             objekts.SayHello();
             objekts.SayHello();
             int rezultats = objekts.GetNumber();//veido jaunu mainīgo (rezultats), lai izsauktu funkciju

             Console.WriteLine(rezultats);

             int rezultats2 = objekts.GetNumber2(100);
             Console.WriteLine(rezultats2);





             // . nozīmē izsaukt objekta funkciju
             //mainīgo nosaukumi nedrīkst atkārtoties*/

           /* uzdevumi uzdevumi = new uzdevumi();
            uzdevumi.Uzdevums1("Jekaterina");
            uzdevumi.Uzdevums2(142, 23);*/


            Console.ReadLine();
                
                
                
        }
    }
}
