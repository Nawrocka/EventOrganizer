using System;
using System.Collections.Generic;


namespace EventOrganizer.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
    }
}
