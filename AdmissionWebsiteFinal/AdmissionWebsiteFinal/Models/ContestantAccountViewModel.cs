using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class ContestantAccountViewModel
    {
        public ContestantViewModel Contestant { get; set; }
        public AdmissionEntryViewModel Entry { get; set; }
        public IEnumerable<OptionViewModel> EntryOptions { get; set; }
    }
}
