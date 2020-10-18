using CreditCardApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Services
{
    public class CreditCardCalculatorService : ICreditCardCalculatorService
    {
        private ICardRepository _cardsRepo;
        public CreditCardCalculatorService(ICardRepository cardsRepo)
        {
            _cardsRepo = cardsRepo;
        }
        public Card CalculateCardType(Application app)
        {
            int age = CalculateAge(app.DateOfBirth);
            if (age < 18)
            {
                return null;
            }
            else if (app.AnnualIncome > 30000)
            {
                return _cardsRepo.GetCardByType(CardType.BarclayCard);
            }
            else
            {
                return _cardsRepo.GetCardByType(CardType.Vanquish);
            }
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = (DateTime.Now.Year - dateOfBirth.Year);
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return age;
        }
    }
}
