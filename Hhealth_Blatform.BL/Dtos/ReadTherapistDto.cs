using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.BL.Dtos
{
    public class ReadTherapistDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
