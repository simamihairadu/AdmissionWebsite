using AdmissionWebsiteFinal.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class OptionViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Specializations")]
        public int SpecializationId { get; set; }
        public SpecializationViewModel Specialization { get; set; }
        public IEnumerable<SpecializationViewModel> Specializations{ get; set; }
        [Required]
        [Display(Name = "Locuri buget")]
        public int LocuriBuget { get; set; }
        [Required]
        [Display(Name = "Locuri taxa")]
        public int LocuriTaxa { get; set; }
        [Required]
        [Display(Name = "Locuri rromi")]
        public int LocuriRrom { get; set; }
        [Required]
        [Display(Name = "Locuri romani de pretutindeni")]
        public int LocuriRomanDePretutindeni { get; set; }
    }
}
