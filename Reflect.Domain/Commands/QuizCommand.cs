using Reflect.Domain.Core;
using Reflect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflect.Domain.Commands
{
    public abstract class QuizCommand : Command
    {
        public string QuizCategory { get; protected set; }
        public string QuizName { get; set; }
        public List<QuestionAnswer> QuestionAnswer { get; protected set; }
        public Calculation Calculation { get; protected set; }
       
    }
}
