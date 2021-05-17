using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class OptionRepository : Repository<Option>, IOptionRepository
    {
        public OptionRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }

        public IEnumerable<Option> GetOptionsBySessionId(int sessionId)
        {
            return ApplicationDbContext.Options.Where(o => o.SessionId == sessionId).ToList();
        }
    }
}
