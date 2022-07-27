﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using midterm_project.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    [DbContext(typeof(PetDbContext))]
    [Migration("20220727213123_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("midterm_project.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PetAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PetBreed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetSize")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PetURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PetId");

                    b.ToTable("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}
