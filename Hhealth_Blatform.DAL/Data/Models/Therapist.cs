using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.DAL.Data.Models
{
    public class Therapist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;    
        public ICollection<Session> Sessions { get; set; }=new HashSet<Session>();
    }
}
