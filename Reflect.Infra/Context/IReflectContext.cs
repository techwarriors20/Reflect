using MongoDB.Driver;
using Reflect.Domain.Models;

namespace Reflect.Infra.Context
{
    public interface IReflectContext
    {
        IMongoCollection<Quiz> Quizs { get; }
        IMongoCollection<QuizAttempt> Attempts { get; }
    }
}