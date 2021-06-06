using AdmissionWebsiteFinal.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class ExistingContestantViewModel : IContestant
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Score")]
        public float EntryScore { get; set; }
        [Display(Name = "CNP")]
        [Required]
        [CNP]
        public string ContestantId { get; set; }
        public List<EntryOptionViewModel> EntryOptions { get; set; }
        [Required]
        [Display(Name = "Options")]
        public int EntryOptionId { get; set; }
        public bool RromSpot { get; set; }
        [Display(Name = "Roman de pretutindeni Spot")]
        public bool RDPSpot { get; set; }

        public string GetId()
        {
            return ContestantId;
        }
    }
}
