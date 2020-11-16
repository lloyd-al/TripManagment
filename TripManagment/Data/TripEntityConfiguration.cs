using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TripManagment.Data.Models;

namespace TripManagment.Data
{
    public class TripsEntityConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.ToTable("Trips");

            builder.Property(e => e.TripName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.TripDescription)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.Property(e => e.DateStarted)
                .IsRequired();

            builder.Property(e => e.DateCompleted)
                .IsRequired(false);


            builder.HasData(
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "Vienna, Austria",
                    TripDescription = "Vienna, is one the most beautiful cities in Austria and in Europe as well. Other than the Operas for which it is well known, Vienna also has many beautiful parks...",
                    DateStarted = new DateTime(2017, 01, 20),
                    DateCompleted = null
                },
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "Carpinteria, CA, USA",
                    TripDescription = "Carpinteria is a city located on the central coast of California, just south of Santa Barbara. It has many beautiful beaches as well as a popular Avocado Festival which takes place every year in October...",
                    DateStarted = new DateTime(2019, 02, 22),
                    DateCompleted = new DateTime(2019, 01, 30)
                },
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "San Francisco, CA, USA",
                    TripDescription = "San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options...",
                    DateStarted = new DateTime(2019, 01, 27),
                    DateCompleted = new DateTime(2019, 01, 30)
                },
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "Tucson, AZ, USA",
                    TripDescription = "Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently named a world gastronomy city, and is well known for its desert landscape and various bike races...",
                    DateStarted = new DateTime(2019, 01, 20),
                    DateCompleted = null
                },
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "Albuquerque, NM, USA",
                    TripDescription = "Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows.",
                    DateStarted = new DateTime(2015, 01, 20),
                    DateCompleted = new DateTime(2015, 01, 30)
                },
                new Trip
                {
                    Id = Guid.NewGuid(),
                    TripName = "Munich, Germany",
                    TripDescription = "Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks...",
                    DateStarted = new DateTime(2019, 01, 20),
                    DateCompleted = null
                }
            );

        }
    }
}
