using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using API.Models.Entities;
using API.Models.Dtos;
using API.Datasets;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using API.Models.Interfaces;

namespace API.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        
        private readonly IMapper _mapper;
        public DataContext _context { get; set; }
        public IVehicleRepository _repo { get; }

        public VehiclesController(IMapper mapper, DataContext context, IVehicleRepository repository)
        {
            _repo = repository;
            _context = context;
            _mapper = mapper;

        }

#pragma warning disable CS8602
#pragma warning disable CS8604

[HttpGet("{id}")]
     public async Task<IActionResult> GetVehicle(int id)
     {
                    // var vehicle = await _context.Vehicles
                    // .Include(v=>v.Features)
                    // .ThenInclude(vdto=>vdto.Feature)
                    // .Include(v=>v.Model)
                    // .ThenInclude(m=>m.Make)
                    // .SingleOrDefaultAsync(v=>v.Id==id);

var vehicle = await _repo.GetVehicle(id);

                            if (vehicle == null)
                                return NotFound();

                    var vehicleDto=_mapper.Map<Vehicle, VehicleDto>(vehicle);
                    return Ok(vehicleDto);
    
     }



/*
        [HttpPost]    //🛢
        public async Task<IActionResult> CreateVehicle([FromBody] SaveVehicleDto vehicleDto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = await _context.Models.FindAsync(vehicleDto.ModelId);
            if (model == null)
            {
                ModelState.AddModelError("ModelId", "invalid modelId"); //053@6m30
                return BadRequest(ModelState);
            }


          var vehicle = _mapper.Map<SaveVehicleDto, Vehicle>(vehicleDto);
          vehicle.LastUpdate = DateTime.Now;

       //     var vehicle = _repo.GetVehicle(vehicle.Id);

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<Vehicle, SaveVehicleDto>(vehicle);

            return Ok(result);


        }

*/




  [HttpPost]
    public async Task<IActionResult> CreateVehicle([FromBody] SaveVehicleDto vehicleDto)
    {
        if (!ModelState.IsValid)
        return BadRequest(ModelState);

      var vehicle = _mapper.Map<SaveVehicleDto, Vehicle>(vehicleDto);
      vehicle.LastUpdate = DateTime.Now;

      _repo.Add(vehicle);
      await _context.SaveChangesAsync();

      vehicle = await _repo.GetVehicle(vehicle.Id);

      var result = _mapper.Map<Vehicle, VehicleDto>(vehicle);

      return Ok(result);
    }



        [HttpPut("{id}")]
       public async Task<IActionResult> UpdateVehicle(int id, [FromBody] SaveVehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // var vehicle = await _context.Vehicles.Include(v => v.Features)
            // .SingleOrDefaultAsync(v => v.Id == id);

            // var vehicle = await _context.Vehicles
            
            //         .Include(v=>v.Features)
            //         .ThenInclude(vdto=>vdto.Feature)
            //         .Include(v=>v.Model)
            //         .ThenInclude(m=>m.Make)
            //         .SingleOrDefaultAsync(v=>v.Id==id);

var vehicle = await _repo.GetVehicle(id);



               if (vehicle == null)
                     return NotFound();


            _mapper.Map<SaveVehicleDto, Vehicle>(vehicleDto, vehicle);
            vehicle.LastUpdate = DateTime.Now;

            await _context.SaveChangesAsync();
      //        var result = _mapper.Map<Vehicle, VehicleDto>(vehicle);


 var result = _mapper.Map<Vehicle, SaveVehicleDto>(vehicle);


      
            return Ok(result);

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
           // var vehicle = await _context.Vehicles.FindAsync(id);
           var vehicle = await _repo.GetVehicle(id, false);

            if (vehicle == null)
                return NotFound();

            _context.Remove(vehicle);
            await _context.SaveChangesAsync();

            return Ok(id);
        }


// ?? need to confirm this via repo




    }
}








