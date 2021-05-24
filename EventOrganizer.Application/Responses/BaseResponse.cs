using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ValidationErrors { get; set; }

        public BaseResponse()
        {
            ValidationErrors = new List<string>();
            Success = true;
        }

        public BaseResponse(string message = null)
            : this()
        {
            Message = message;
        }

        public BaseResponse(string message, bool success)
            : this(message)
        {
            Success = success;
        }

        public BaseResponse(ValidationResult validationResult)
            : this()
        {
            Success = validationResult.Errors.Count <= 0;

            foreach (var item in validationResult.Errors)
            {
                ValidationErrors.Add(item.ErrorMessage);
            }
        }
    }
}
