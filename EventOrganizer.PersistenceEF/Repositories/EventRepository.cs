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
    public class EventRepository : IEventRepository
    {
        private readonly EventOrganizerContext _dbContext;

        public EventRepository(EventOrganizerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Event entity)
        {
            await _dbContext.Events.AddAsync(entity);
        }

        public void DeleteAsync(Event entity)
        {
            _dbContext.Events.Remove(entity);
        }

        public async Task<IReadOnlyList<Event>> GetAllAsync()
        {
            return await _dbContext.Events.ToListAsync();

        }
        public async Task<Event> GetByIdAsync(int id)
        {
            return await _dbContext.Events.FindAsync(id);
        }
        public void UpdateMaxParticipants(int eventId)
        {
            var appointment = _dbContext.Events.FirstOrDefault(e=>e.Id==eventId);
            appointment.MaxParticipants++;

            _dbContext.Entry(appointment).State = EntityState.Modified;
        }
        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
