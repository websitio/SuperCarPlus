using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

using API.Datasets;
using API.Models.Entities;
using API.Models.Dtos;

namespace API.Controllers
{
    public class MakesController : Controller
    {
        public  readonly DataContext _context;
        public IMapper _mapper { get; }


        public MakesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
         }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeDto>> GetMakes()
        {
           var makes= await _context.Makes.Include(m => m.Models).ToListAsync();

           return _mapper.Map<List<Make>, List<MakeDto>>(makes);
        }
    }
}