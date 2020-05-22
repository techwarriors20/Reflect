using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Infrastructure.Exceptions
{
    public class ReflectDomainException : Exception
    {
        public ReflectDomainException()
        {

        }

        public ReflectDomainException(string message)
            : base(message)
        { }

        public ReflectDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
