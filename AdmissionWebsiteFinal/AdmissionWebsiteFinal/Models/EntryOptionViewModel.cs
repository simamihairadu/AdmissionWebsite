using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class EntryOptionViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Specializations")]
        public int SpecializationId { get; set; }
        public string Name { get; set; }
    }
}
