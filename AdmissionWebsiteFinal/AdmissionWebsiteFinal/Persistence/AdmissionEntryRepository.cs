using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdmissionWebsiteFinal.Data;

namespace AdmissionWebsiteFinal.Persistence
{
    public class AdmissionEntryRepository : Repository<AdmissionEntry>, IAdmissionEntryRepository
    {
        public AdmissionEntryRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }

        public AdmissionEntry GetAdmissionEntryByContestant(string id)
        {
            var entry = ApplicationDbContext.AdmissionEntries.Where(a => a.ContestantId == id).
                OrderByDescending(a => a.Id).First();
            return entry;
        }

        public override AdmissionEntry Get(int id)
        {
            return ApplicationDbContext.AdmissionEntries.Where(a => a.Id == id).
                Include(a => a.Contestant).FirstOrDefault();
        }

        public List<AdmissionEntry> GetAdmissionEntriesBySessionId(int sessionId)
        {
            var options = ApplicationDbContext.EntryOptions.Include(o => o.AdmissionEntry).
                Include(o => o.Option).
                Include(e => e.AdmissionEntry.Contestant).
                Where(o => o.Option.SessionId == sessionId);

            HashSet<AdmissionEntry> entries = new HashSet<AdmissionEntry>();
            foreach (var item in options)
            {
                entries.Add(item.AdmissionEntry);
            }
            return entries.ToList();
        }

        public bool GetEntryStatus(int entryId, int optionId)
        {
            return ApplicationDbContext.EntryOptions.Where(e => e.AdmissionEntryId == entryId && e.OptionId == optionId).FirstOrDefault().Confirmed;
        }

        public List<AdmissionEntry> GetAdmissionEntriesByOptionId(int optionId)
        {
            var entryOptions = ApplicationDbContext.EntryOptions.Where(e => e.OptionId == optionId).
                Include(e =>e.AdmissionEntry).
                Include(e => e.AdmissionEntry.Contestant).
                OrderByDescending(e => e.AdmissionEntry.EntryScore);
            List<AdmissionEntry> entries = new List<AdmissionEntry>();

            foreach (var item in entryOptions)
            {
                entries.Add(item.AdmissionEntry);
            }
            return entries;
        }
    }
}
