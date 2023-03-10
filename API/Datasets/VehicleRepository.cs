using API.Models.Entities;
using API.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Datasets
{
   
#pragma warning disable CS8602, CS8603, CS0162, CS8618, CS0649
    public class VehicleRepository : IVehicleRepository
    {
        private Vehicle vehicle;

        public DataContext _context { get; }

        public VehicleRepository(DataContext context)
        {
            _context = context;

        }


        public async Task<Vehicle> GetVehicle(int Id, bool includeRelated=true)
        {

                        if(!includeRelated) {return await _context.Vehicles.FindAsync(Id);}


                      return  await _context.Vehicles
                        .Include(v => v.Features)
                        .ThenInclude(vdto => vdto.Feature)
                        .Include(v => v.Model)
                        .ThenInclude(m => m.Make)
                        .SingleOrDefaultAsync(v => v.Id == Id);
      if (vehicle == null) { }
         throw new Exception("Supercar is on a mission, try a bus");

//  if (vehicle.Model?.Make == null)
//         throw new Exception("Vehicle make not found");
return vehicle;
        }
        #pragma warning restore CS8602



public void Add(Vehicle vehicle) 
    {
      _context.Vehicles.Add(vehicle);
    }



public void Remove(Vehicle vehicle)
    {
      _context.Remove(vehicle);
    }

 


    }
}