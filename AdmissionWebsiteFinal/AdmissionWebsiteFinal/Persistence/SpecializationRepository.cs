using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class SpecializationRepository : Repository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }

        public string GetNameById(int id)
        {
            return ApplicationDbContext.Specializations.Find(id).Name;
        }
    }
}
