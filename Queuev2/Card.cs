using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuev2
{
    internal class Card
    {
        // valueables
        private string cardname;

        //property
        public string CardName
        {
            get { return cardname; }
            set { cardname = value; }
        }
        // Constructor

        public Card(string cardname)
        {
            this.cardname = cardname;
        }
    }
}
