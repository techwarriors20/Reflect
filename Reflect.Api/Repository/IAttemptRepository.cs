using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Reflect.Api.Data;
using Reflect.Api.Helpers;
using Reflect.Api.Models;

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