using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BlackJack
{
    class Card
    {
       
            /// <summary>
            /// Vērtība
            /// </summary>
            public string Value;
            /// <summary>
            /// Masts
            /// </summary>
            public char Suit;

            /// <summary>
            /// izveido jaunu kārti
            /// </summary>
            /// <param name="value"></param>
            /// <param name="suit"></param>

            public Card(string value, char suit)
            {
                this.Value = value;
                this.Suit = suit;
            }
            /// <summary>
            /// kārts skaitliskā vērtība
            /// </summary>
            /// <returns></returns>
            public int GetValue()
            {
                return 0;
            }

        public static implicit operator Card(List<Card> v)
        {
            throw new NotImplementedException();
        }
    }  

    
}
