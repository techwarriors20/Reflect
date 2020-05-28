using Reflect.Application.Interfaces;
using Reflect.Application.ViewModels;
using Reflect.Domain.Commands;
using Reflect.Domain.Core;
using Reflect.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Reflect.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Reflect.Application.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public QuizService(IQuizRepository quizRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _quizRepository = quizRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(QuizViewModel quizViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateQuizCommand>(quizViewModel));
        }

        void IQuizService.Create(QuizViewModel quizViewModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<QuizViewModel> IQuizService.GetQuizs()
        {
            throw new NotImplementedException();
        }

        // public IEnumerable<QuizViewModel> GetQuizs()
        // {
        //return _quizRepository.GetAllQuiz().ProjectTo<QuizViewModel>(_autoMapper.ConfigurationProvider);
        //}
    }
}
