using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hhealth_Blatform.DAL.Data.Models;
namespace Hhealth_Blatform.DAL.Repos
{
    public interface ISessionRepository
    {
        Task<List<Hhealth_Blatform.DAL.Data.Models.Session>> GetAll();
        Task< IQueryable<Hhealth_Blatform.DAL.Data.Models.Session>> GetQuerable();
        void SaveChanges();
    }
}
