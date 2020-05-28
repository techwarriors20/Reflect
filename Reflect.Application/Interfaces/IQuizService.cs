using Reflect.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflect.Application.Interfaces
{
    public interface IQuizService
    {
        IEnumerable<QuizViewModel> GetQuizs();
        void Create(QuizViewModel quizViewModel);
    }
}
