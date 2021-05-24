using EventOrganizer.Domain.Entities;
using EventOrganizer.PersistenceEF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventOrganizer.PersistenceEF
{
    public class EventOrganizerContext : DbContext
    {
        public EventOrganizerContext(DbContextOptions<EventOrganizerContext> options)
            :base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.Entity<EventParticipant>()
                .HasOne(e=>e.Event)
                .WithMany(ep=>ep.EventParticipants)
                .HasForeignKey(ei=>ei.EventId);

            modelBuilder.Entity<EventParticipant>()
                .HasOne(e => e.Participant)
                .WithMany(ep => ep.EventParticipants)
                .HasForeignKey(ei => ei.ParticipantId);

            modelBuilder.SeedEvent();
            modelBuilder.SeedParticipant();
            modelBuilder.SeedEventsParticipants();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<EventParticipant> EventsParticipants { get; set; }
    }
}
