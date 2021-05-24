using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Contracts.Persistence
{
    public interface IEventRepository
    {
        Task AddAsync(Event entity);
        void Delete(Event entity);
        void UpdateMaxParticipants(int eventId);
        Task<IReadOnlyList<Event>> GetAllAsync();
        Task<Event> GetByIdAsync(int id);
        Task Save();
    }
}
