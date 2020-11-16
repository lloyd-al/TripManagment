using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagment.Data.Models;

namespace TripManagment.Data.Services
{
    public class TripService : ITripService
    {
        private TripDbContext _dbContext;

        public TripService(TripDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Trip>> GetAll()
        {
            var trips = await _dbContext.Trips.ToListAsync<Trip>();
            return trips;
        }

        public async Task<Trip> GetById(Guid tripId)
        {
            var trip = await _dbContext.Trips.Where(tripid => tripid.Id == tripId).FirstOrDefaultAsync();
            return trip;
        }

        public async Task<Guid> Create(Trip trip)
        {
            trip.Id = Guid.NewGuid(); 
            await _dbContext.Trips.AddAsync(trip);
            await _dbContext.SaveChanges();
            return trip.Id;
        }

        public async Task Update(Guid tripId, Trip trip)
        {
            var tripDetails = await _dbContext.Trips.Where(tripid => tripid.Id == tripId).FirstOrDefaultAsync();

            if (tripDetails != null)
            {
                tripDetails.TripName = trip.TripName;
                tripDetails.TripDescription = trip.TripDescription;
                tripDetails.DateStarted = trip.DateStarted;
                tripDetails.DateCompleted = trip.DateCompleted;

                await _dbContext.SaveChanges();
            }
        }

        public async Task<int> Delete(Guid tripId)
        {
            int result = 0;

            var tripDetails = await _dbContext.Trips.Where(tripid => tripid.Id == tripId).FirstOrDefaultAsync();
            if (tripDetails == null) return result;

            _dbContext.Trips.Remove(tripDetails);
            result = await _dbContext.SaveChanges();
            return result;
        }
    }
}
