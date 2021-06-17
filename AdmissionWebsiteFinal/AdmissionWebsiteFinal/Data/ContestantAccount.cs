using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Data
{
    public class ContestantAccount : IdentityUser
    {
        [ForeignKey("ContestantId")]
        public Contestant Contestant { get; set; }
        public string ContestantId { get; set; }
    }
}
