using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Reflect.Domain.CommandHandlers;
using Reflect.Domain.Commands;
using Reflect.Domain.Core;
using Reflect.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflect.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateQuizCommand, bool>, QuizCommandHandler>();

            //Application Layer 
           // services.AddScoped<IQuizService, QuizService>();

            //Infra.Data Layer
           // services.AddScoped<IQuizRepository, QuizRepository>();
           // services.AddScoped<ReflectDBContext>();
        }
    }
}
