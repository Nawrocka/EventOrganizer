using EventOrganizer.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.PersistenceEF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventOrganizerContext _dbContext;
        private EventRepository _eventRepo;
        private ParticipantRepository _participantRepo;
        private EventParticipantRepository _eventparticipantRepo;

        public UnitOfWork(EventOrganizerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEventRepository Events
        {
            get
            {
                //if eventRepo is null then compute right side (here create new repo)
                return _eventRepo ??= new EventRepository(_dbContext);
            }
        }

        public IParticipantRepository Participants
        {
            get
            {
                return _participantRepo ??= new ParticipantRepository(_dbContext);
            }
        }

        public IEventParticipantRepository EventsParticipants
        {
            get
            {
                return _eventparticipantRepo ??= new EventParticipantRepository(_dbContext);
            }
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
