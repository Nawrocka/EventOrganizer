using AutoMapper;
using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Application.ModelDTO;
using EventOrganizer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventOrganizer.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ParticipantController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ParticipantController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost(Name = "Create")]
        public async Task<ActionResult> Create(ParticipantDTO participant)
        {
            var mappedParticipant = _mapper.Map<Participant>(participant);

            await _unitOfWork.Participants.AddAsync(mappedParticipant);
            await _unitOfWork.Participants.Save();

            return NoContent();
        }

        [HttpGet(Name = "GetAll")]
        public async Task<ActionResult<List<ParticipantDTO>>> GetAll()
        {
            var participants = await _unitOfWork.Participants.GetAllAsync();

            return _mapper.Map<List<ParticipantDTO>>(participants);
        }
    }
}
