using MongoDB.Driver;
using Reflect.Api.Helpers;
using Reflect.Api.Models;

namespace Reflect.Api.Data
{
    public interface IReflectContext
    {
        IMongoCollection<Quiz> Quizs { get; }
        IMongoCollection<QuizAttempt> Attempts { get; }
    }
}