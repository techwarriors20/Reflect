using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Models
{
    public class AnswerList
    {
        public string Answer { get; set; }
        public long IsCorrect { get; set; }
        public string AnswerDetail { get; set; }
    }
}
