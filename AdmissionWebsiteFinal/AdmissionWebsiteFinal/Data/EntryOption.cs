using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Data
{
    public class EntryOption
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AdmissionEntryId")]
        public AdmissionEntry AdmissionEntry { get; set; }
        public int AdmissionEntryId { get; set; }
        [ForeignKey("OptionId")]
        public Option Option { get; set; }
        public int OptionId { get; set; }
        public bool Confirmed { get; set; }
    }
}
