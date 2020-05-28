using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reflect.Domain.Models;

namespace Reflect.Domain.Interfaces
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