﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PiwoBack.Repository.ApplicationDbContext;
using System;

namespace PiwoBack.Repository.Migrations
{
    [DbContext(typeof(PiwoDbContext))]
    [Migration("20180413143242_dasdad")]
    partial class dasdad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PiwoBack.Data.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Alcohol");

                    b.Property<double?>("Blg");

                    b.Property<int?>("BreweryId");

                    b.Property<string>("Color");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<double?>("Ibu");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BreweryId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.BeerRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BeerId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("Rate");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.ToTable("BeerRate");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.Brewery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrewingGroupId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BrewingGroupId");

                    b.ToTable("Breweries");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.BrewingGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BrewingGroups");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BeerId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BeerId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<DateTime>("RegisterDate");

                    b.Property<int?>("RoleId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.Beer", b =>
                {
                    b.HasOne("PiwoBack.Data.Models.Brewery", "Brewery")
                        .WithMany("Beers")
                        .HasForeignKey("BreweryId");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.BeerRate", b =>
                {
                    b.HasOne("PiwoBack.Data.Models.Beer", "Beer")
                        .WithMany("BeerRates")
                        .HasForeignKey("BeerId");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.Brewery", b =>
                {
                    b.HasOne("PiwoBack.Data.Models.BrewingGroup", "BrewingGroup")
                        .WithMany("Breweries")
                        .HasForeignKey("BrewingGroupId");
                });

            modelBuilder.Entity("PiwoBack.Data.Models.Comment", b =>
                {
                    b.HasOne("PiwoBack.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PiwoBack.Data.Models.Beer", "Beer")
                        .WithMany("Comments")
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PiwoBack.Data.Models.User", b =>
                {
                    b.HasOne("PiwoBack.Data.Models.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
