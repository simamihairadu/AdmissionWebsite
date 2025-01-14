﻿using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public class ContestantRepository: Repository<Contestant>,IContestantRepository
    {
        public ContestantRepository(ApplicationDbContext context) : base(context) { }
        public ApplicationDbContext ApplicationDbContext { get { return context as ApplicationDbContext; } }
        public Contestant Get(string id)
        {
            return ApplicationDbContext.Contestants.Find(id);
        }
    }
}
