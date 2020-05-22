using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Reflect.Api.Data;
using Reflect.Api.Helpers;
using Reflect.Api.Models;

namespace Reflect.Api.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private readonly IReflectContext _context;
        private readonly ILogger<QuizRepository> _logger;

        public QuizRepository(IReflectContext context, ILogger<QuizRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Quiz>> GetAllQuiz()
        {
            _logger.LogInformation("GetAllQuiz initiated");
            return await _context
                            .Quizs
                            .Find(_ => true)
                            .ToListAsync();
        }
        
        
        public async Task<Quiz> GetQuizById(string id)
        {
            _logger.LogInformation("GetQuizById initiated");
            return await _context.Quizs.FindSync(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            
        }

        public async Task CreateQuiz(Quiz @quiz)
        {
            await _context.Quizs.InsertOneAsync(@quiz);
            _logger.LogInformation("CreateQuiz success");
        }

        public async Task<bool> UpdateQuiz(Quiz quiz)
        {
            await _context.Quizs.ReplaceOneAsync(x => x.Id.Equals(quiz.Id), quiz);
            _logger.LogInformation("UpdateQuiz success");
            return true;
        }
        
        public async void DeleteQuiz(string id)
        {
            await _context.Quizs.DeleteOneAsync(x => x.Id.Equals(id));
            _logger.LogInformation("DeleteQuiz success");
        }

       
      
    }
}