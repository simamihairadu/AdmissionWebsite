using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AdmissionWebsiteFinal.Models;

namespace AdmissionWebsiteFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EntryOption> EntryOptions { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<AdmissionEntry> AdmissionEntries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ContestantAccount> ContestantAccounts { get; set; }
    }
}
