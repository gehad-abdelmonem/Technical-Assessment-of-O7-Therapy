using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.DAL.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int ReferanceNo { get; set; }
       public ICollection<Session> Sessions { get; set; }=new HashSet<Session>();
    }
}
