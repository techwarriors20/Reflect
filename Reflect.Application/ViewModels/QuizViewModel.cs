using Reflect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflect.Application.ViewModels
{
    public class QuizViewModel
    {
        public string QuizCategory { get; protected set; }
        public string QuizName { get; set; }
        public List<QuestionAnswer> QuestionAnswer { get; protected set; }
        public Calculation Calculation { get; protected set; }
    }
}
