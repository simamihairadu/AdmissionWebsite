using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class AdmissionEntryViewModel
    {
        public int Id { get; set; }
        public ContestantViewModel Contestant { get; set; }
        [Required]
        [Display(Name = "Score")]
        public float EntryScore { get; set; }
        public string ContestantId { get; set; }
        public IEnumerable<EntryOptionViewModel> EntryOptions { get; set; }
        [Required]
        [Display(Name = "Options")]
        public int EntryOptionId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
