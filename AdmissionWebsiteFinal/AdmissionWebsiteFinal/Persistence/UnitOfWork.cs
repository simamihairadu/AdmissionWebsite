using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IAdmissionEntryRepository AdmissionEntries { get; private set; }
        public IContestantRepository Contestants { get; private set; }
        public IDepartmentRepository Departments { get; private set; }
        public ISessionRepository Sessions { get; private set; }
        public IEmployeeRepository Employees { get; set; }
        public IOptionRepository Options { get; }
        public ISpecializationRepository Specializations { get; }
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            AdmissionEntries = new AdmissionEntryRepository(this.context);
            Contestants = new ContestantRepository(this.context);
            Departments = new DepartmentRepository(this.context);
            Sessions = new SessionRepository(this.context);
            Employees = new EmployeeRepository(this.context);
            Options = new OptionRepository(this.context);
            Specializations = new SpecializationRepository(this.context);
        }
        public int Complete()
        {
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
