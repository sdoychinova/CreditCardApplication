using CreditCardApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Services
{
    public interface ICreditCardCalculatorService
    {
        public Card CalculateCardType(Application app);
    }
}
