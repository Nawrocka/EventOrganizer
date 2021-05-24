using EventOrganizer.Application.Contracts.Persistence;
using EventOrganizer.PersistenceEF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.PersistenceEF
{
    public static class PersistenceEFInstallation
    {
        public static IServiceCollection AddEventOrganizerPersistenceEFServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventOrganizerContext>(options =>
                options.UseSqlServer(configuration
                .GetConnectionString("EventOrganizerConnectionString")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IParticipantRepository, ParticipantRepository>();

            return services;
        }
    }
}
