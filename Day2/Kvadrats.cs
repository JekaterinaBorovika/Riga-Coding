using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Kvadrats
    {
        public string Krasa;
        public int MalasGarums;

        //konstruktoru parasti ievieto aiz īpašībām
        public Kvadrats()//konstruktors
        {

        }
        public Kvadrats(string krasa, int garums)
        {
            this.Krasa = krasa;
            this.MalasGarums = garums;
        }
        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir " + this.Krasa);
            Console.WriteLine("Malas garums ir " + MalasGarums);
        }

            public int Laukums()
            {
                return this.MalasGarums * this.MalasGarums;
                //var arī tā: return MalasGarums * MalasGarums
            }
            public int Perimetrs()
            {
                return MalasGarums * 4;


            }

        
    }
}
