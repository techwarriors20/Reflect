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
    [Route("api/v1/quiz")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _quizRepository;

        public QuizController(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        // GET: api/v1/quiz/GetAllQuizs
        [HttpGet("GetAllQuizs")]
      //  [Authorize(Roles = RoleNames.ADMIN + "," + RoleNames.USER)]
        public async Task<IActionResult> GetAllQuiz()
        {
            return new ObjectResult(await _quizRepository.GetAllQuiz());
        }

        // GET: api/v1/quiz/GetQuizById
        [HttpGet("GetQuizById")]
      //  [Authorize(Roles = RoleNames.ADMIN + "," + RoleNames.USER)]
        public async Task<IActionResult> GetQuiz(string id)
        {
            var @quiz = await _quizRepository.GetQuizById(id);

            if (@quiz == null)
                return new NotFoundResult();

            return new ObjectResult(@quiz);
        }

        // POST: api/v1/quiz/CreateQuiz
        [HttpPost("CreateQuiz")]
        //[Authorize(Roles = RoleNames.ADMIN)]
        public async Task<IActionResult> Post([FromBody] Quiz @quiz)
        {
            await _quizRepository.CreateQuiz(@quiz);
            return new OkObjectResult(@quiz);
        }

        // PUT: api/v1/quiz/UpdateQuiz
        [HttpPut("UpdateQuiz")]
        //[Authorize(Roles = RoleNames.USER)]
        public async Task<IActionResult> Upate(Quiz @quiz)
        {
            await _quizRepository.UpdateQuiz(@quiz);
            return new OkObjectResult(@quiz);
        }

        // PUT: api/v1/quiz/UpdateQuiz
        [HttpDelete("DeleteQuiz")]
        //[Authorize(Roles = RoleNames.USER)]
        public IActionResult Delete(string id)
        {
             _quizRepository.DeleteQuiz(id);
            return new OkObjectResult("Deleted");
        }
    }
}
