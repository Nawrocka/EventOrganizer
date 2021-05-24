using EventOrganizer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Contracts.Persistence
{
    public interface IParticipantRepository
    {
        Task AddAsync(Participant entity);
        Task<IReadOnlyList<Participant>> GetAllAsync();
        //void Edit(Participant entity);
        Task Save();
    }
}
