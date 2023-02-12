using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers.Errors
{
    
    
     // #pragma warning disable CS8625
    
    public class ApiExeception
    {
        public ApiExeception(int statusCode, string? message = null, string? details = null)
        {
            StatusCode = statusCode;
            Message = message ?? string.Empty;
            Details = details ?? string.Empty;
        }

        public int StatusCode { get; }
        public string Message { get; }
        public string Details { get;  }


    }
}