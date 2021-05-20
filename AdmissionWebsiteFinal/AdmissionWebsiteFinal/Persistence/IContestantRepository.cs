using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdmissionWebsiteFinal.Data;

namespace AdmissionWebsiteFinal.Persistence
{
    public interface IContestantRepository : IRepository<Contestant>
    {
        Contestant Get(string id);
    }
}
