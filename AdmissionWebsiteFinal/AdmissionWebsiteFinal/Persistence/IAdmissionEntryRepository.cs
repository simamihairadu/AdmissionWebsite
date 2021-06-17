using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdmissionWebsiteFinal.Data;

namespace AdmissionWebsiteFinal.Persistence
{
    public interface IAdmissionEntryRepository : IRepository<AdmissionEntry>
    {
        AdmissionEntry GetAdmissionEntryByContestant(string id);
        List<AdmissionEntry> GetAdmissionEntriesBySessionId(int sessionId);
        List<AdmissionEntry> GetAdmissionEntriesByOptionId(int sessionId);
        bool GetEntryStatus(int entryId, int optionId);
    }
}
