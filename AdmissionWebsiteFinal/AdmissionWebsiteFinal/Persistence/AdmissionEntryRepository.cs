using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdmissionWebsiteFinal.Data;

namespace AdmissionWebsiteFinal.Persistence
{
    public class AdmissionEntryRepository : Repository<AdmissionEntry>, IAdmissionEntryRepository
    {
        public AdmissionEntryRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }
    }
}
