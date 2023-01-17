using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Deck
    {
        private List<Card> cards;
        public List<Card> Cards
        {
            get { return cards; }
        }

        public int Count
        {
            get { return cards.Count; }
        }

        public Deck()
        {
            cards = new List<Card>();
            string[] faces = { "Diamonds", "Hearts", "Clubs", "Spades" };
            object[] values = { "Ace", 2, 3, 4, 5, 6, 7, 8, 9, 10, "Jack", "Queen", "King" };

            foreach (string f in faces)
            {
                foreach (object v in values)
                {
                    cards.Add(new Card(f, v.ToString()));
                }
            }
        }
    }
}
