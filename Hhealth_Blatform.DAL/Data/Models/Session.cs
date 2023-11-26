using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.DAL.Data.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        public int Rate { get; set; }
        public DateTime SessionDate { get; set; }
        public DateTime submissionDate { get; set; }
        [ForeignKey("Therapist")]
        public int TherapistId { get; set; }
        public double TherapistRatting { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public Therapist? Therapist { get; set; }
    }
}
