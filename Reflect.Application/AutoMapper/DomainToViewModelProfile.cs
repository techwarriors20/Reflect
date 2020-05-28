using AutoMapper;
using Reflect.Application.ViewModels;
using Reflect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Quiz, QuizViewModel>();
        }
    }
}
