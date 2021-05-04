using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class SessionRepository : Repository<Session>, ISessionRepository
    {
        public SessionRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }

        public bool IsAnyActive()
        {
            return ApplicationDbContext.Sessions.Any(s => s.Active == true);
        }
        public Session GetActiveSession()
        {
            return ApplicationDbContext.Sessions.Where(s => s.Active == true).FirstOrDefault();
        }
    }
}
