using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Models
{
    public class ApplicationRepository:IApplicationRepository
    {
        private readonly AppDbContext _appDbContext;
        public ApplicationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Application> AllApplications
        {
            get
            {
                return _appDbContext.Applications.Include(c=>c.ApplicationCardResult);
            }
        }

        public void SaveApplication(Application app)
        {
            _appDbContext.Applications.Add(app);
            _appDbContext.SaveChanges();
        }
    }
}
