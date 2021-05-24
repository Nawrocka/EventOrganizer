using EventOrganizer.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.Application
{
    public static class ApplicationInstallation
    {
        public static IServiceCollection AddApplicationInstallation(this IServiceCollection services)
        {
            //services.AddAutoMapper(c => c.AddProfile<MappingProfile>());
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
