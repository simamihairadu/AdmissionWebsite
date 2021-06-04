using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class StandingViewModel
    {
        public int OptionId { get; set; }
        public IEnumerable<OptionViewModel> Options { get; set; }
        public IEnumerable<AdmissionEntryViewModel> Entries { get; set; }
        public IEnumerable<AdmissionEntryViewModel> BugetEntries { get; set; }
        public IEnumerable<AdmissionEntryViewModel> TaxaEntries { get; set; }
        public IEnumerable<AdmissionEntryViewModel> RromEntries { get; set; }
        public IEnumerable<AdmissionEntryViewModel> RDPEntries { get; set; }
    }
}
