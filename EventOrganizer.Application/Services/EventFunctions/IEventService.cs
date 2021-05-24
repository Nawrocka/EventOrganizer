using EventOrganizer.Application.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Services.EventFunctions
{
    public interface IEventService
    {
        Task Create(EventDTO appointment);
        Task<IReadOnlyList<EventDTO>> GetAll();
        Task<IReadOnlyList<EventWithParticipantsDTO>> GetAllWithParticipants();
        Task Delete(int id);
    }
}
