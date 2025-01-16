using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPSLS_Endpoint.Services;

namespace RPSLS_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSGameController : ControllerBase
    {
        public readonly RPSLSGameService _rpslsGameService;

        public RPSLSGameController (RPSLSGameService rpslsGameService)
        {
            _rpslsGameService = rpslsGameService;
        }

        [HttpGet]
        [Route("RPSLSCPUResponse")]
        public string PlayGame()
        {
            return _rpslsGameService.CPUResponse();
        }
        
    }
}