using EventOrganizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer.PersistenceEF.Configuration
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Email).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(32);
            builder.Property(p => p.EventParticipants).IsRequired();
        }
    }
}
