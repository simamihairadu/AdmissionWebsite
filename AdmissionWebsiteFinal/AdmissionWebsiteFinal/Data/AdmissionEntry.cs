using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Data
{
    public class AdmissionEntry
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ContestantId")]
        public Contestant Contestant { get; set; }
        public float EntryScore { get; set; }
        public string ContestantId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        public bool RromSpot { get; set; }
        public bool RDPSpot { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
