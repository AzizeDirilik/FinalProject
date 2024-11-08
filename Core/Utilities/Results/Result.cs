using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
        }
        public Result(bool isSuccess)
        {
            Success = isSuccess;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
