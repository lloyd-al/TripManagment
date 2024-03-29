﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripManagment.Data;

namespace TripManagment.Migrations
{
    [DbContext(typeof(TripDbContext))]
    [Migration("20201110122021_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TripManagment.Data.Models.Trip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("TripDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TripName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = new Guid("960078a3-6f1f-4367-af8e-75793c2f4322"),
                            DateStarted = new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "Vienna, is one the most beautiful cities in Austria and in Europe as well. Other than the Operas for which it is well known, Vienna also has many beautiful parks...",
                            TripName = "Vienna, Austria"
                        },
                        new
                        {
                            Id = new Guid("065fa04b-aeed-4fa9-a1d5-3fcbe0b15aab"),
                            DateCompleted = new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "Carpinteria is a city located on the central coast of California, just south of Santa Barbara. It has many beautiful beaches as well as a popular Avocado Festival which takes place every year in October...",
                            TripName = "Carpinteria, CA, USA"
                        },
                        new
                        {
                            Id = new Guid("f12eb82e-ba6b-4e07-9e3b-32b9d05b4c50"),
                            DateCompleted = new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2019, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options...",
                            TripName = "San Francisco, CA, USA"
                        },
                        new
                        {
                            Id = new Guid("0f4a7809-ecfe-43fe-8277-890e5df3d122"),
                            DateStarted = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently named a world gastronomy city, and is well known for its desert landscape and various bike races...",
                            TripName = "Tucson, AZ, USA"
                        },
                        new
                        {
                            Id = new Guid("593805aa-07b7-42df-9ce2-ab48a28fb848"),
                            DateCompleted = new DateTime(2015, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateStarted = new DateTime(2015, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows.",
                            TripName = "Albuquerque, NM, USA"
                        },
                        new
                        {
                            Id = new Guid("dd0a778f-f500-4288-a6ea-bb3bbf449d09"),
                            DateStarted = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripDescription = "Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks...",
                            TripName = "Munich, Germany"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
