﻿using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public interface ISpecializationRepository : IRepository<Specialization>
    {
        string GetNameById(int id);
    }
}
