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
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly EventOrganizerContext _dbContext;

        public ParticipantRepository(EventOrganizerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Participant entity)
        {
            await _dbContext.Participants.AddAsync(entity);
        }

        public async Task<IReadOnlyList<Participant>> GetAllAsync()
        {
            return await _dbContext.Participants.ToListAsync();
        }

        //public void Edit(Participant entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //}

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
