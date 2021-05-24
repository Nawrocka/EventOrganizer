using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.ModelDTO
{
    public class ParticipantsDTO
    {
        public int ParticipantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
