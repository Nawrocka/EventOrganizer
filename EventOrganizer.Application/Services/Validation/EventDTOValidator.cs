using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Application.ModelDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Services.Validation
{
    public class EventDTOValidator: AbstractValidator<EventDTO>
    {
        //private readonly TimeSpan minTimeSpan = new TimeSpan(0,0,0);

        public EventDTOValidator()
        {
            RuleFor(e => e.MaxParticipants)
                .LessThan(26)
                .WithMessage("Max amount of participants have been achieved");

            RuleFor(e => e.Title)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();

            RuleFor(e => e.StartDate)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .GreaterThan(DateTime.Now.AddDays(-1)); //from existing day to infinit in the future

            //RuleFor(e => e.Duration)
            //    .NotEmpty()
            //    .WithMessage("{PropertyName} is required")
            //    .GreaterThan(minTimeSpan);
                
        }
    }
}
