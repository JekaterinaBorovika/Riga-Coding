using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BlackJack
{
    public class Deck
    {

        public char[] Suits = { 'H', 'D', 'S', 'C' };

        public string[] Values =  { "2", "3", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        /// <summary>
        /// Kārtis (saraksts ar kārtīm)
        /// </summary>
        public List<Card>[] Cards;
        /// <summary>
        /// izveido jaunu kāršu kavu
        /// </summary>
        /// <returns></returns>
        public Deck()
        {
            Cards = new List<Card>();
            foreach(char s in Suits)
            {
                foreach(string v in Values)
                {
                    //pievieno kārti kāršu kavai
                    Cards.Add(new Card(v, s));
                }
            }
        }
        public Card TakeCard()
        {
            Card newCard = Cards[0];
            Cards.RemoveAt(0);//izņem pirmo elementu no saraksta

            return newCard;
        }

        public Deck TakeNewDeck()
        {
            return null;
        }

        public void Shuffle()
        {

        }
    }
}
