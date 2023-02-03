using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models.Dtos;
using API.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Datasets;

namespace API.Controllers
{
    public class FeaturesController : Controller
  {
    private readonly DataContext context;
    private readonly IMapper mapper;
    public FeaturesController(DataContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<NameIdBaseDto>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<NameIdBaseDto>>(features); 
    }
  }
}