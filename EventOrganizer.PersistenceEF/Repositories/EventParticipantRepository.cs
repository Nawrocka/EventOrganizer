using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.PersistenceEF.Repositories
{
    public class EventParticipantRepository : IEventParticipantRepository
    {
        private readonly EventOrganizerContext _dbContext;

        public EventParticipantRepository(EventOrganizerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<EventParticipant>> GetAllAsync()
        {
            return await _dbContext.EventsParticipants.ToListAsync();
        }

        public async Task AddAsync(EventParticipant entity)
        {
            await _dbContext.EventsParticipants.AddAsync(entity);
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
