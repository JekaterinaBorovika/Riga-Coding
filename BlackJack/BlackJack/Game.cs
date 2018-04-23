using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BlackJack
{
    public class Game//public nozīmē, ka funcija ir izsaucama pilnīgi no jebkurienes
    {
        public Dealer Dealer;
        public Player Player;
        public Deck Deck;

        public bool StartNewGame()
        {
            
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli");


            /*Console.Write("Vai uzsākt jaunu spēli (jā/nē)? ");
            string atbilde = Console.ReadLine().ToLower();
            bool startNew = atbilde == "jā";*/

            if (startNew)
            {
            Console.WriteLine("Uzsākta jauna spēle!");
                Deck new Deck();//pārbaudīt uzraksīto!!
                Dealer new Dealer();
                Player new Player();
                
    }

            return startNew;
            
        }

        public static bool GetAnswer(string question)
        {//lai nerakstītu visu laiku vienu un to pašu jautājumu, raksta šādu funkciju
            Console.Write(question + "(jā/nē)? ");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā";

            return answer;
        }
    }
}
