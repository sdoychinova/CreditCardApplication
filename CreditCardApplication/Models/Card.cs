using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public decimal APR { get; set; }
        public string PromotionalMessage { get; set; }

        public CardType Type { get; set; }

        public bool IsEmpty()
        {
            return APR == 0 && PromotionalMessage == null;

        }

    }
}
