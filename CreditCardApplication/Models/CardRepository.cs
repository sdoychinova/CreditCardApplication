using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class CardRepository : ICardRepository
    {
        private readonly AppDbContext _appDbContext;
        public CardRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Card GetCardByType(CardType type)
        {
            return _appDbContext.Cards.Where(c => c.Type == type).FirstOrDefault();
        }
    }
}
