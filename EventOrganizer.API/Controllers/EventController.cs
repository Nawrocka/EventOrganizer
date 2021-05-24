using AutoMapper;
using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Application.ModelDTO;
using EventOrganizer.Application.Services.EventFunctions;
using EventOrganizer.Application.Services.Validation;
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
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<ActionResult<EventDTOResponse>> Create([FromBody] EventDTO appointment)
        {
            var response = await _eventService.Create(appointment);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EventDTO>>> GetAll()
        {
            return new ActionResult<IReadOnlyList<EventDTO>>(await _eventService.GetAll());
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EventWithParticipantsDTO>>> GetAllWithParticipants()
        {
            return new ActionResult<IReadOnlyList<EventWithParticipantsDTO>>
                (await _eventService.GetAllWithParticipants());
        }

        [HttpDelete("{id}", Name ="DeleteEvent")]
        public async Task<ActionResult> Delete(int id)
        {
            await _eventService.Delete(id);
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
