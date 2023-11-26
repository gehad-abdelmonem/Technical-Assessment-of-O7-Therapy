using Hhealth_Blatform.BL.Dtos;
using Hhealth_Blatform.BL.Helpers;
using Hhealth_Blatform.BL.Mangers.session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HhealthBlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IsessionService _sessionService;
        public SessionController(IsessionService sessionService)
        {
            _sessionService = sessionService;

        }

        [HttpGet]
        public async Task<ActionResult<List<ReadSessionDto>>> GetAll()
        {
            var result = await _sessionService.GetSessions();
            return Ok(result);
        }
        [HttpGet]
        [Route("paginate")]
        public async Task<ActionResult<PaginationResult<ReadSessionDto>>> GetPaginate([FromQuery] SessionParams sessionParams)
        {
            var data = await _sessionService.GetPagination(sessionParams);
            return Ok(data);
        }
    }
}
