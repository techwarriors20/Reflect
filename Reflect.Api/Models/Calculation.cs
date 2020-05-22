using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflect.Api.Models
{
    public class Calculation
    {
        public string Type { get; set; }
        public List<Result> Result { get; set; }
        public string AdditionalDisplay { get; set; }
    }
}
