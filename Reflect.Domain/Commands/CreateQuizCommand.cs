using Reflect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflect.Domain.Commands
{
    public class CreateQuizCommand : QuizCommand
    {
        public CreateQuizCommand(string quizCategory, string quizName, List<QuestionAnswer> questionAnswer, Calculation calculation)
        {
            QuizCategory = quizCategory;
            QuizName = quizName;
            QuestionAnswer = questionAnswer;
            Calculation = calculation;
        }
    }
}
