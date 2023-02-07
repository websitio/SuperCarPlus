using API.Datasets;
using API.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Interfaces
{
    public interface IVehicleRepository
    {
        DataContext _context { get; }

        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);


    }

}