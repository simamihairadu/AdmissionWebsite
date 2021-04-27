using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IAdmissionEntryRepository AdmissionEntries { get; }
        IContestantRepository Contestants { get; }
        IDepartmentRepository Departments { get; }
        ISessionRepository Sessions { get; }
        int Complete();
    }
}
