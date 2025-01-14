﻿using AdmissionWebsiteFinal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class EntryOptionRepository : Repository<EntryOption>, IEntryOptionRepository
    {
        public EntryOptionRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }

        public List<EntryOption> GetEntryOptionsByEntryId(int entryId)
        {
            return ApplicationDbContext.EntryOptions.Where(o => o.AdmissionEntryId == entryId).
                Include(o => o.Option).
                Include(o => o.Option.Session).
                Include(o => o.Option.Specialization).ToList();
        }

        public override EntryOption Get(int id)
        {
            return ApplicationDbContext.EntryOptions.Where(e =>e.Id == id).Include(e => e.Option.Session).FirstOrDefault();
        }
    }
}
