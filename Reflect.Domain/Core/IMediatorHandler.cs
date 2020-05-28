using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Domain.Core
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
