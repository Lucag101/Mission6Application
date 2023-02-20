﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6Application.Models;

namespace Mission6Application.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6Application.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            CategoryId = 1,
                            Director = "Not sure",
                            Edited = true,
                            Lent = "Sarah Mackinley",
                            Notes = "Good Movie. A Little Old",
                            Rating = "PG",
                            Title = "Harry Potter and the Sorcerer's stone",
                            Year = 2004
                        },
                        new
                        {
                            ApplicationId = 2,
                            CategoryId = 6,
                            Director = "Again,Not sure",
                            Edited = false,
                            Lent = "",
                            Notes = "Kind of sad but good",
                            Rating = "PG-13",
                            Title = "The Prestige",
                            Year = 2008
                        },
                        new
                        {
                            ApplicationId = 3,
                            CategoryId = 1,
                            Director = "I feel like I should know, but I don't",
                            Edited = true,
                            Lent = "I would never lend this to anybody",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord Of the Rings",
                            Year = 2006
                        });
                });

            modelBuilder.Entity("Mission6Application.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Sci-Fi/ Fantasy"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Children"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Suspense"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Holiday"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Animated"
                        });
                });

            modelBuilder.Entity("Mission6Application.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission6Application.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
