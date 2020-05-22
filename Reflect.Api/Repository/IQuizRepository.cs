using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Reflect.Api.Data;
using Reflect.Api.Helpers;
using Reflect.Api.Models;

namespace Reflect.Api.Repository
{
    public interface IQuizRepository
    {
        Task<IEnumerable<Quiz>> GetAllQuiz();
       
        Task<Quiz> GetQuizById(string id);

        Task CreateQuiz(Quiz @quiz);
        Task<bool> UpdateQuiz(Quiz @quiz);

        void DeleteQuiz(string id);

    }
}