using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {



            Deck deck = new Deck();
            deck.Shuffle(3);

/*            List<Card> newList = deck.Cards.Where(x => x.Suit == Suit.Clubs).ToList();
*/
            

            /*            foreach (Card card in deck.Cards)
                        {
                            Console.WriteLine(card.Face + " of " + card.Suit);
                        }
                        Console.WriteLine(deck.Cards.Count);
                        Console.ReadLine();
                    }
            */


            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
        }
    }
}
