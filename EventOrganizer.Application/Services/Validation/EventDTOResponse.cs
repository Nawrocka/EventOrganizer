using EventOrganizer.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Services.Validation
{
    public class EventDTOResponse : BaseResponse
    {
        public EventDTOResponse()
            : base()
        { }

        public EventDTOResponse(string message)
            : base(message)
        { }

        public EventDTOResponse(string message, bool success)
            : base(message, success)
        { }

        public EventDTOResponse(ValidationResult validationResult)
            : base(validationResult)
        { }
    }
}
