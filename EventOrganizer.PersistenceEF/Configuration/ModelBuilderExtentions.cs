using EventOrganizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.PersistenceEF.Configuration
{
    public static class ModelBuilderExtentions 
    {
        public static void SeedEvent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event()
                {
                    Id = 1,
                    Title = "Restful API, wszystkoco powinieneś wiedzieć.",
                    Description = @"Przedstawimy zagadnienia, które będą wprowadzeniami do głębszego poznawania RESTful APIs.
                    Pierwsze spotkanie będzie wstępem i przedstawieniemz szerszej perspektywy, kontekstu, do którego wrócimy 
                    na ostatnim spotkaniu z cyklu. Taka agendowa klamra wyczerpie temat RESTful API na wieki, a przynajmniej 
                    do kolejnego nowego pomysłu, zmiany wprowadzonej w świat IT.",
                    StartDate = DateTime.Now.AddMonths(2),
                    Duration = new TimeSpan(2, 0, 0)
                },

                new Event()
                {
                    Id = 2,
                    Title = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,
                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  
                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. 
                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. 
                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.",
                    StartDate = DateTime.Now.AddMonths(3),
                    Duration = new TimeSpan(4, 0, 0)
                },

                new Event()
                {
                    Id = 3,
                    Title = "Docker niech Twoja firma wypłynie na szerokie wody",
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,
                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  
                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. 
                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. 
                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.",
                    StartDate = DateTime.Now.AddMonths(5),
                    Duration = new TimeSpan(2, 15, 0)
                },

                new Event()
                {
                    Id = 4,
                    Title = "JavaScript, TypeScript, czy może jakiś framework?",
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,
                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  
                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. 
                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. 
                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.",
                    StartDate = DateTime.Now.AddMonths(3).AddDays(6),
                    Duration = new TimeSpan(2, 30, 0)
                },

                new Event()
                {
                    Id = 5,
                    Title = "ADO.NET bo Entity Framework już nie wystarcza, a być może nigdy nie wystarczał.",
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,
                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  
                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. 
                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. 
                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.",
                    StartDate = DateTime.Now.AddMonths(3).AddDays(20).AddHours(5),
                    Duration = new TimeSpan(3, 45, 0)
                });
        }

        public static void SeedParticipant(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant>().HasData(
                new Participant()
                {
                    Id = 1,
                    Name = "Maria",
                    Email = "maria@gmail.com"
                },

                new Participant()
                {
                    Id = 2,
                    Name = "Tomek",
                    Email = "tomek@gmail.com"
                },

                new Participant()
                {
                    Id = 3,
                    Name = "Lili",
                    Email = "lili@gmail.com"
                },

                new Participant()
                {
                    Id = 4,
                    Name = "Kasia",
                    Email = "kasia@gmail.com"
                });
        }

        public static void SeedEventsParticipants(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventParticipant>().HasData(
                new EventParticipant()
                {
                    Id=1,
                    EventId = 1,
                    ParticipantId = 1
                },

                new EventParticipant()
                {
                    Id = 2,
                    EventId = 3,
                    ParticipantId = 1
                },

                new EventParticipant()
                {
                    Id = 3,
                    EventId = 5,
                    ParticipantId = 1
                },

                new EventParticipant()
                {
                    Id = 4,
                    EventId = 2,
                    ParticipantId = 2
                },

                new EventParticipant()
                {
                    Id = 5,
                    EventId = 5,
                    ParticipantId = 3
                },

                new EventParticipant()
                {
                    Id = 6,
                    EventId = 4,
                    ParticipantId = 3
                },

                new EventParticipant()
                {
                    Id = 7,
                    EventId = 3,
                    ParticipantId = 3
                },

                new EventParticipant()
                {
                    Id = 8,
                    EventId = 1,
                    ParticipantId = 4
                },

                new EventParticipant()
                {
                    Id = 9,
                    EventId = 5,
                    ParticipantId = 4
                });
        }
    }
}
