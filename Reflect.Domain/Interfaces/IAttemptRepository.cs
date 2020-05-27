using System.Collections.Generic;
using System.Threading.Tasks;
using Reflect.Domain.Models;

namespace Reflect.Api.Repository
{
    public interface IAttemptRepository
    {
        Task<IEnumerable<QuizAttempt>> GetAllAttempt();

        Task<IEnumerable<QuizAttempt>> GetAllAttemptByUserId(string userId);

        Task<QuizAttempt> GetAttemptById(string id);

        Task CreateAttempt(QuizAttempt @quizAttempt);       

    }
}