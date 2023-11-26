using AutoMapper;
using Hhealth_Blatform.BL.Dtos;
using Hhealth_Blatform.BL.Helpers;
using Hhealth_Blatform.DAL.Data.Models;
using Hhealth_Blatform.DAL.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.BL.Mangers.session
{
    public class SessionService : IsessionService
    {
        private readonly ISessionRepository _sessionRepository;
        private readonly IMapper _mapper;
        public SessionService(ISessionRepository session,IMapper mapper)
        {
            _sessionRepository= session;
            _mapper= mapper;
        }

        public async Task<PaginationResult<ReadSessionDto>> GetPagination(SessionParams SessionParams)
        {
            IQueryable<Session> query = await _sessionRepository.GetQuerable();
            if(SessionParams.SessionRating!=null)
            {
                query = query.Where(s=>s.Rate==SessionParams.SessionRating);
            }
            int skiped = (SessionParams.PageNumber - 1) * SessionParams._PageSize;
            var data = await query.Skip(skiped).Take(SessionParams.PageSize).ToListAsync();
            var mappedData = _mapper.Map<List<ReadSessionDto>>(data);
            var count = query.Count();
            return new PaginationResult<ReadSessionDto>
            {
                PageNumber = SessionParams.PageNumber,
                PageSize = SessionParams.PageSize,
                TotalCount = count,
                Data = mappedData
            };

        }

        public async Task<List<ReadSessionDto>> GetSessions()
        {
            var dataFromDb = await _sessionRepository.GetAll();
            return _mapper.Map<List<ReadSessionDto>>(dataFromDb);
        }

       
    }
}
