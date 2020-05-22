using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reflect.Api.Models;
using Reflect.Api.Repository;
using static Reflect.Api.Helpers.Constants;

namespace Reflect.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/attempt")]
    public class AttemptController : ControllerBase
    {
        private readonly IAttemptRepository _attemptRepository;

        public AttemptController(IAttemptRepository attemptRepository)
        {
            _attemptRepository = attemptRepository;
        }

        // GET: api/v1/attempt/GetAllAttempt
        [HttpGet("GetAllAttempt")]
      //  [Authorize(Roles = RoleNames.ADMIN + "," + RoleNames.USER)]
        public async Task<IActionResult> GetAllAttempt()
        {
            return new ObjectResult(await _attemptRepository.GetAllAttempt());
        }

        // GET: api/v1/attempt/GetAllAttemptByUserId
        [HttpGet("GetAllAttemptByUserId")]
        //  [Authorize(Roles = RoleNames.ADMIN + "," + RoleNames.USER)]
        public async Task<IActionResult> GetAllAttemptByUserId(string userId)
        {
            return new ObjectResult(await _attemptRepository.GetAllAttemptByUserId(userId));
        }
                
        // GET: api/v1/attempt/GetAttemptById
        [HttpGet("GetAttemptById")]
      //  [Authorize(Roles = RoleNames.ADMIN + "," + RoleNames.USER)]
        public async Task<IActionResult> GetAttempt(string id)
        {
            var @attempt = await _attemptRepository.GetAttemptById(id);

            if (@attempt == null)
                return new NotFoundResult();

            return new ObjectResult(@attempt);
        }

        // POST: api/v1/attempt/CreateAttempt
        [HttpPost("CreateAttempt")]
        //[Authorize(Roles = RoleNames.ADMIN)]
        public async Task<IActionResult> Post([FromBody] QuizAttempt @attempt)
        {
            await _attemptRepository.CreateAttempt(@attempt);
            return new OkObjectResult(@attempt);
        }
        
    }
}
