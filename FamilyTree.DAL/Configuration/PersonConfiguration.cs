using FamilyTree.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree.DAL.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("people", "family_tree");

            builder.Property(p => p.Name)
                .HasMaxLength(30);

            builder.Property(p => p.Surname)
                .HasMaxLength(30);

            builder.HasOne(p => p.Spouse)
                .WithOne()
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
