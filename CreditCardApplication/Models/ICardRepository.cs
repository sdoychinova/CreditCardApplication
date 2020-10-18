using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public interface ICardRepository
    {
        public Card GetCardByType(CardType type);
    }
}
