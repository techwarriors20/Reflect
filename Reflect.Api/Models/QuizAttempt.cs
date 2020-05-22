using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Models
{
    [BsonIgnoreExtraElements]
    public class QuizAttempt
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public long QuizId { get; set; }
        public long UserId { get; set; }       
        public string QuizDate { get; set; }
        public long Score { get; set; }
        public string InputYes { get; set; }
        public string InputNo { get; set; }
        public string InputSomeWhat { get; set; }
       
    }
       
}
