using Hhealth_Blatform.BL.Dtos;
using Hhealth_Blatform.BL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.BL.Mangers.session
{
    public interface IsessionService
    {
        Task<List<ReadSessionDto>> GetSessions();
        Task< PaginationResult<ReadSessionDto>> GetPagination(SessionParams SessionParams);
    }
}
