using Hhealth_Blatform.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.DAL.Data.context
{
    public class HealthContext:DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Therapist> Therapists { get; set; }
        public HealthContext(DbContextOptions options):base(options)
        {

        }
    }
}
