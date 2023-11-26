using Hhealth_Blatform.DAL.Data.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.DAL.Repos.Session
{
    public class SessionRepository : ISessionRepository
    {
        private readonly HealthContext _context;
        public SessionRepository(HealthContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Data.Models.Session>> GetQuerable()
        {
            IQueryable<Hhealth_Blatform.DAL.Data.Models.Session> query = _context.Sessions.Include(s=>s.Therapist);
            return query;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        async Task<List<Data.Models.Session>> ISessionRepository.GetAll()
        {
            return await _context.Sessions.Include(t=>t.Therapist).ToListAsync();
        }
    }
}
