using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Program
    {
       public static void Main(string[] args)
        {
            UzdevumsPirmais VirkneSkaitlu = new UzdevumsPirmais();
            VirkneSkaitlu.Virkne();
          
            
            UzdevumsTresais AtrumaParkapejs = new UzdevumsTresais();
            AtrumaParkapejs.Sodi();

            Console.ReadLine();


        }
    }
}
