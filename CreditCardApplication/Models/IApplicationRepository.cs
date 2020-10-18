using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Application> AllApplications { get; }
        void SaveApplication(Application app);
    }
}
