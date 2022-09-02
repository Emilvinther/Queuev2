using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuev2
{
    internal class Manager
    {
        // queue list
        Queue<Card> cards = new Queue<Card>();

        // constructer making cards and put them into the queue list
        public Manager()
        {
            Card card1 = new Card("Card1");
            Card card2 = new Card("Card2");
            Card card3 = new Card("Card3");
            Card card4 = new Card("Card4");
            Card card5 = new Card("Card5");


            cards.Enqueue(card1);
            cards.Enqueue(card2);
            cards.Enqueue(card3);
            cards.Enqueue(card4);
            cards.Enqueue(card5);
        }

        // queue card
        public void EnqueueCard(string add)
        {
            cards.Enqueue(new Card(add));
        }

        // remove card
        public void Dequeue()
        {
            cards.Dequeue();
        }

        // number of items in the queue
        public int NumberOfItems()
        {
            return cards.Count;
        }

        // top and buttom card
        public string MinMaxItems()
        {
            List<Card> card = cards.ToList();

            Card max = card[card.Count() - 1];

            Card min = cards.Peek();

            return $"Min:{min} Max{max}";
        }


        // find card
        public string FindItem(string cardname)
        {
            string temp = "";
            //Linq solution
            //List<Card> card = cards.Where(x => x.Cardname.Contains(cardname)).ToList();

            List<Card> card = new List<Card>();

            // checks card up again excisting cards
            foreach (Card i in cards)
            {
                if (cardname == i.CardName)
                {
                    card.Add(i);
                }

            }

            // shows cards in list

            if (card.Count() != 0)
            {
                foreach (Card i in card)
                {
                    temp = temp + i.CardName;
                }

            }

            return temp;


        }

        // prints all card
        public string PrintAll()
        {
            string temp = "";

            foreach (Card i in cards)
            {

                temp += i.CardName + "\n";

            }

            return temp;
        }
    }
}
