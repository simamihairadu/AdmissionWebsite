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
        [Range(0, 100,ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Score")]
        public float EntryScore { get; set; }
        [Display(Name = "CNP")]
        public string ContestantId { get; set; }
        public List<EntryOptionViewModel> EntryOptions { get; set; }
        public List<OptionViewModel> Options { get; set; }
        [Required]
        [Display(Name = "Options")]
        public int EntryOptionId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
