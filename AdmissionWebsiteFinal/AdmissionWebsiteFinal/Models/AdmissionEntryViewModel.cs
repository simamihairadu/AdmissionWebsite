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
        public float EntryScore { get; set; }
        public string ContestantId { get; set; }
        [Required]
        [Display(Name = "Departments")]
        public IEnumerable<DepartmentViewModel> Departments { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
