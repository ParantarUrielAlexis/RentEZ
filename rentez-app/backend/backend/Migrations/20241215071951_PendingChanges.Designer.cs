﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(RentEZDbContext))]
    [Migration("20241215071951_PendingChanges")]
    partial class PendingChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Bathroom")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Bedroom")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Person")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Proximity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PropertyID");

                    b.HasIndex("UserID");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            PropertyID = 1,
                            Bathroom = 0m,
                            Bedroom = 0m,
                            City = "Metropolis",
                            Description = "A cozy apartment in the heart of the city.",
                            ImageUrl1 = "",
                            ImageUrl2 = "",
                            ImageUrl3 = "",
                            ImageUrl4 = "",
                            Name = "Cozy Apartment",
                            Person = 0m,
                            Price = 1200.00m,
                            Province = "NY",
                            Proximity = "",
                            Street = "123 Main St",
                            Type = "",
                            UserID = 1
                        },
                        new
                        {
                            PropertyID = 2,
                            Bathroom = 0m,
                            Bedroom = 0m,
                            City = "Gotham",
                            Description = "A luxurious villa with stunning views.",
                            ImageUrl1 = "",
                            ImageUrl2 = "",
                            ImageUrl3 = "",
                            ImageUrl4 = "",
                            Name = "Luxury Villa",
                            Person = 0m,
                            Price = 5000.00m,
                            Province = "CA",
                            Proximity = "",
                            Street = "456 Elm St",
                            Type = "",
                            UserID = 2
                        });
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Property", b =>
                {
                    b.HasOne("backend.Models.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
