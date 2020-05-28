using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Reflect.Domain.Models;

namespace Reflect.Infra.Context
{
    public class ReflectContext : IReflectContext
    {
        private readonly IMongoDatabase _db;

        public ReflectContext(IOptions<MongoSettings> options, IMongoClient client)
        {
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Quiz> Quizs => _db.GetCollection<Quiz>("Quizs");
        public IMongoCollection<QuizAttempt> Attempts => _db.GetCollection<QuizAttempt>("Attempts");
    }
}