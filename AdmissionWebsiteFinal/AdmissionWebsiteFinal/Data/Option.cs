using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Data
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("SpecializationId")]
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        [ForeignKey("SessionId")]
        public Session Session { get; set; }
        public int SessionId { get; set; }
        public int LocuriBuget { get; set; }
        public int LocuriTaxa { get; set; }
        public int LocuriRrom { get; set; }
        public int LocuriRomanDePretutindeni { get; set; }
    }
}
