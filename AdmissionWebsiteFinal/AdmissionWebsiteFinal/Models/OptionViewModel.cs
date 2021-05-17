using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class OptionViewModel
    {
        public int Id { get; set; }
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public IEnumerable<SpecializationViewModel> Specializations{ get; set; }
        public int LocuriBuget { get; set; }
        public int LocuriTaxa { get; set; }
        public int LocuriRrom { get; set; }
        public int LocuriRomanDePretutindeni { get; set; }
    }
}
