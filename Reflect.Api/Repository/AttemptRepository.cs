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
    public class AttemptRepository : IAttemptRepository
    {
        private readonly IReflectContext _context;
        private readonly ILogger<QuizRepository> _logger;

        public AttemptRepository(IReflectContext context, ILogger<QuizRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<QuizAttempt>> GetAllAttempt()
        {
            _logger.LogInformation("GetAllAttempt initiated");
            return await _context
                            .Attempts
                            .Find(_ => true)
                            .ToListAsync();
        }

        public async Task<IEnumerable<QuizAttempt>> GetAllAttemptByUserId(string userId)
        {
            _logger.LogInformation("GetAllAttempt initiated");
            return await _context
                            .Attempts
                            .Find(x => x.UserId.Equals(userId))
                            .ToListAsync();
        }

        public async Task<QuizAttempt> GetAttemptById(string id)
        {
            _logger.LogInformation("GetAttemptById initiated");
            return await _context.Attempts.FindSync(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            
        }

        public async Task CreateAttempt(QuizAttempt quizAttempt)
        {
            await _context.Attempts.InsertOneAsync(quizAttempt);
            _logger.LogInformation("CreateAttempt success");
        }
             
      
    }
}