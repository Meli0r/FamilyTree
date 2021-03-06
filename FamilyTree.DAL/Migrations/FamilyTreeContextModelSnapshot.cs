﻿// <auto-generated />
using System;
using FamilyTree.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FamilyTree.DAL.Migrations
{
    [DbContext(typeof(FamilyTreeContext))]
    partial class FamilyTreeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FamilyTree.DAL.Entities.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnName("birthdate");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(30);

                    b.Property<long?>("SpouseId")
                        .HasColumnName("spouse_id");

                    b.Property<string>("Surname")
                        .HasColumnName("surname")
                        .HasMaxLength(30);

                    b.HasKey("Id")
                        .HasName("pk_people");

                    b.HasIndex("SpouseId")
                        .IsUnique()
                        .HasName("ix_people_spouse_id");

                    b.ToTable("people","family_tree");
                });

            modelBuilder.Entity("FamilyTree.DAL.Entities.Person", b =>
                {
                    b.HasOne("FamilyTree.DAL.Entities.Person", "Spouse")
                        .WithOne()
                        .HasForeignKey("FamilyTree.DAL.Entities.Person", "SpouseId")
                        .HasConstraintName("fk_people_people_spouse_id")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
