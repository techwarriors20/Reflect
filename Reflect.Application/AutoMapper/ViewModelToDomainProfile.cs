using AutoMapper;
using Reflect.Application.ViewModels;
using Reflect.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<QuizViewModel, CreateQuizCommand>()
                .ConstructUsing(c => new CreateQuizCommand(c.QuizCategory, c.QuizName, c.QuestionAnswer,c.Calculation));
        }
    }
}
