using MediatR;
using Reflect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Reflect.Domain.Commands;
using Reflect.Domain.Interfaces;

namespace Reflect.Domain.CommandHandlers
{
    public class QuizCommandHandler : IRequestHandler<CreateQuizCommand, bool>
    {
        private readonly IQuizRepository _quizRepository;

        public QuizCommandHandler(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public Task<bool> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = new Quiz()
            {
                QuizCategory = request.QuizCategory,
                QuizName = request.QuizName,
                QuestionAnswer = request.QuestionAnswer,
                Calculation = request.Calculation
            };

            _quizRepository.CreateQuiz(quiz);

            return Task.FromResult(true);
        }
    }
}
