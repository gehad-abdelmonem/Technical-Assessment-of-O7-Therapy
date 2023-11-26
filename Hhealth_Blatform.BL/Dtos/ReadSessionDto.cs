using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.BL.Dtos
{
    public class ReadSessionDto
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public double TherapistRatting { get; set; }
        public DateTime SessionDate { get; set; }
        public DateTime submissionDate { get; set; }
        public ReadTherapistDto Therapist { get; set; }
    }
}
