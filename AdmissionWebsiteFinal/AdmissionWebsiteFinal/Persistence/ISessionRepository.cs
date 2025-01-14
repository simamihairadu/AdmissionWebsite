﻿using AdmissionWebsiteFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Persistence
{
    public interface ISessionRepository : IRepository<Session>
    {
        bool IsAnyActive();
        Session GetActiveSession();
    }
}
