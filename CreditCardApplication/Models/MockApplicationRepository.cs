using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class MockApplicationRepository : IApplicationRepository
    {
        private List<Application> _appsList = new List<Application>();

        public MockApplicationRepository()
        {
            _appsList = new List<Application>
            {
                new Application{AnnualIncome=35000,ApplicationCardResult = new Card(){Type=CardType.BarclayCard,APR=10,PromotionalMessage="Success"},
                    DateOfBirth=DateTime.Now.AddYears(-20),FisrtName="Sisi",LastName="Pisi"},
                new Application{AnnualIncome=15000,ApplicationCardResult = new Card(){Type=CardType.Vanquish,APR=30,PromotionalMessage="Success Eli"},
                    DateOfBirth=DateTime.Now.AddYears(-20),FisrtName="Eli",LastName="Beli"},
                 new Application{AnnualIncome=15000,
                    DateOfBirth=DateTime.Now.AddYears(-10),FisrtName="Baby",LastName="Baby"}
            };
        }

        public IEnumerable<Application> AllApplications
        {
            get
            {
                return _appsList;
            }
        }
           
        public void SaveApplication(Application app)
        {
            _appsList.Add(app);
        }
    }
}
