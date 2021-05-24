using AutoMapper;
using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Application.ModelDTO;
using EventOrganizer.Application.Services.Validation;
using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Services.EventFunctions
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EventService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<EventDTOResponse> Create(EventDTO appointment)
        {
            var mappedEvent = _mapper.Map<Event>(appointment);
            //Fluent validation
            var validator = new EventDTOValidator();
            var validatorResult = await validator.ValidateAsync(appointment);

            if (!validatorResult.IsValid)
                return new EventDTOResponse(validatorResult);
            
            await _unitOfWork.Events.AddAsync(mappedEvent);
            await _unitOfWork.Events.Save();

            return new EventDTOResponse("Added event with success");
        }

        public async Task<IReadOnlyList<EventDTO>> GetAll()
        {
            var events = await _unitOfWork.Events.GetAllAsync();
        
            return _mapper.Map<List<EventDTO>>(events);
        }
        public async Task<IReadOnlyList<EventWithParticipantsDTO>> GetAllWithParticipants()
        {
            var events = await _unitOfWork.Events.GetAllAsync();
            var eventParticipantList = await _unitOfWork.EventsParticipants.GetAllAsync();
            var participants = await _unitOfWork.Participants.GetAllAsync();

            foreach (var appointment in events)
            {
                appointment.EventParticipants = eventParticipantList.Where(e => e.EventId == appointment.Id).ToList();
            }

            var eventsWithParticipants = _mapper.Map<List<EventWithParticipantsDTO>>(events);

            foreach (var item in eventsWithParticipants)
            {
                foreach (var participant in item.EventParticipants)
                {
                    var thisParticipant = participants.FirstOrDefault(p => p.Id == participant.ParticipantId);
                    participant.Email = thisParticipant.Email;
                    participant.Name = thisParticipant.Name;
                }
            }

            return eventsWithParticipants;
        }

        public async Task Delete(int id)
        {
            //nie usuwa Participantow tego eventu z tabeli participants bo na tym polega zbieranie danych o ludziach xd"
            //chociaz wymagana bylaby jakas wczesniejsza akceptacja regulaminu = rodo ;P
            var appointment = await _unitOfWork.Events.GetByIdAsync(id);

            _unitOfWork.Events.Delete(appointment);
            await _unitOfWork.Events.Save();
        }
    }
}
