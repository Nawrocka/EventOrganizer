using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Contracts.Persistence
{
    public interface IEventParticipantRepository
    {
        Task<ICollection<EventParticipant>> GetAllAsync();
        Task AddAsync(EventParticipant entity);
        Task Save();
    }
}
