using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagment.Data.Models;

namespace TripManagment.Data.Services
{
    public interface ITripService
    {
        Task<List<Trip>> GetAll();
        Task<Trip> GetById(Guid tripId);
        Task<Guid> Create(Trip trip);
        Task Update(Guid tripId, Trip trip);
        Task<int> Delete(Guid tripId);
    }
}
