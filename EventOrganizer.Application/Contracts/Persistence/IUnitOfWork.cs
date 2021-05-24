﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        IEventRepository Events { get; }
        IParticipantRepository Participants { get; }
        IEventParticipantRepository EventsParticipants { get; }
        Task Commit();
    }
}
