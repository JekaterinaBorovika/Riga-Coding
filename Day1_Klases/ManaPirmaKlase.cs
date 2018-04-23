using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    public class ManaPirmaKlase
    {
        /// <summary>
        /// funkcijas bez rezultāta 
        /// bez ievadparametriem
        /// </summary>
        public void SayHello(){
            Console.WriteLine("Hello");
        }
        /// <summary>
        /// funkcija ar rezultātu
        /// un bez ievadparametriem
        /// </summary>
        /// <returns></returns>

        public int GetNumber(){
            return 99;
        }
        /// <summary>
        /// funckija ar rezultātu 
        /// un ar ievadparametru
        /// </summary>
        /// <param name="skaitlis"></param>
        /// <returns></returns>

        public int GetNumber2(int skaitlis){
            return skaitlis;

        
            

            }
    }
}
