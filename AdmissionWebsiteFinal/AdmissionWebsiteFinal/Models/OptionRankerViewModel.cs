using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class OptionRankerViewModel
    {
        public OptionViewModel Option { get; set; }
        public List<AdmissionEntryViewModel> Entries { get; set; }

    }
}
