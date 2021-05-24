using AutoMapper;
using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Application.ModelDTO;
using EventOrganizer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventOrganizer.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class EventController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EventController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] EventDTO appointment)
        {
            var mappedEvent = _mapper.Map<Event>(appointment);
            //Fluent validation
            //response messages/code return
            await _unitOfWork.Events.AddAsync(mappedEvent);
            await _unitOfWork.Events.Save();

            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EventDTO>>> GetAll()
        {
            var events = await _unitOfWork.Events.GetAllAsync();

            return _mapper.Map<List<EventDTO>>(events);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EventWithParticipantsDTO>>> GetAllWithParticipants()
        {
            var events = await _unitOfWork.Events.GetAllAsync();
            var eventParticipantList = await _unitOfWork.EventsParticipants.GetAllAsync();
            var participants = await _unitOfWork.Participants.GetAllAsync();

            foreach (var appointment in events)
            {
                appointment.EventParticipants = eventParticipantList.Where(e=>e.EventId == appointment.Id).ToList();
            }

            var eventsWithParticipants= _mapper.Map<List<EventWithParticipantsDTO>>(events);

            foreach(var item in eventsWithParticipants)
            {
                foreach(var participant in item.EventParticipants)
                {
                    var thisParticipant = participants.FirstOrDefault(p => p.Id == participant.ParticipantId);
                    participant.Email = thisParticipant.Email;
                    participant.Name = thisParticipant.Name;
                }
            }

            return eventsWithParticipants;
        }

        [HttpDelete("{id}", Name ="DeleteEvent")]
        public async Task<ActionResult> Delete(int id)
        {
            var appointment = await _unitOfWork.Events.GetByIdAsync(id);

            _unitOfWork.Events.DeleteAsync(appointment);
            await _unitOfWork.Events.Save();

            return NoContent();
        }

        //You've not ask for it so I commented it.
        //[HttpGet("{id}", Name ="GetEvent")]
        //public async Task<ActionResult<EventDTO>> GetById(int id)
        //{
        //    var eventToMap = await _unitOfWork.Events.GetByIdAsync(id);
        //    return _mapper.Map<EventDTO>(eventToMap);
        //}

    }
}
