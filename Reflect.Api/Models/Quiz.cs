using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Models
{
    [BsonIgnoreExtraElements]
    public class Quiz
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string QuizCategory { get; set; }
        public string QuizName { get; set; }
        public List<QuestionAnswer> QuestionAnswer { get; set; }
        public Calculation Calculation { get; set; }
    }   
}
