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
    public class EventParticipantController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EventParticipantController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //Mogłam/powinnam nie wystawiac tego endpoint, lecz chciałam zaprezentować dwa HttpPost w jednym kontrolerze
        [HttpPost(Name="CreateNewSignUp")]
        public async Task<ActionResult> CreateNewSignUp(ParticipantSignUpDTO participantToSignUp)
        {
            var updatedParticipants = await _unitOfWork.Participants.GetAllAsync();

            var thisParticipantId = updatedParticipants.FirstOrDefault(p => p.Email == participantToSignUp.Email).Id;

            var eventParticipant = new EventParticipant()
            {
                EventId = participantToSignUp.EventId,
                ParticipantId = thisParticipantId
            };

            await _unitOfWork.EventsParticipants.AddAsync(eventParticipant);
            await _unitOfWork.EventsParticipants.Save();

            return NoContent();
        }

        [HttpPost(Name = "SignUp")]
        public async Task<ActionResult> SignUp([FromBody] ParticipantSignUpDTO participantToSignUp)
        {
            var participants = await _unitOfWork.Participants.GetAllAsync();

            if (!participants.Any(p => p.Email == participantToSignUp.Email))
            {
                var mappedParticipant = _mapper.Map<ParticipantDTO>(participantToSignUp);

                await new ParticipantController(_unitOfWork, _mapper).Create(mappedParticipant);

                await CreateNewSignUp(participantToSignUp);

                return NoContent();
            }
            else
            {
                //zakładam, że event istnieje i jest poprawny, ponieważ na froncie
                //będzie on wybierany z select listy, czy coś, a nie wprowadzany ręcznie przez usera
                await CreateNewSignUp(participantToSignUp);
                return NoContent();
            }
        }
    }
}
