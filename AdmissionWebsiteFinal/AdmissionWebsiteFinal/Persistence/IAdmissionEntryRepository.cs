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
        List<AdmissionEntry> GetAdmissionEntriesByOptionId(int optionId);
        bool GetEntryStatus(int entryId, int optionId);
        IEnumerable<AdmissionEntry> SearchEntry(string searchTerm, int sessionId);
    }
}
