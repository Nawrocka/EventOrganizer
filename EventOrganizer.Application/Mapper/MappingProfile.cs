using AutoMapper;
using EventOrganizer.Application.ModelDTO;
using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Participant, ParticipantDTO>().ReverseMap();
            CreateMap<Event, EventWithParticipantsDTO>().ReverseMap();
            CreateMap<EventParticipant, ParticipantsDTO>().ReverseMap();
            CreateMap<ParticipantSignUpDTO, ParticipantDTO>().ReverseMap();
            CreateMap<Participant, ParticipantSignUpDTO>().ReverseMap();
        }
    }
}
