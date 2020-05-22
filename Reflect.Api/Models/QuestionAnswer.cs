using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Models
{
    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string AnswerType { get; set; }
        public List<AnswerList> Answers { get; set; }
    }
}
