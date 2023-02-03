using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using API.Models.Entities;

namespace API.Models.Dtos
{
    public class VehicleDto
    {

        public int Id { get; set; }
        public ModelDto? Model { get; set; }
        public MakeWithNoModelsDto? Make { get; set; }
        [Required]
        public ContactDto? Contact { get; set; }

        public bool IsRegistered { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<FeatureDto> Features { get; set; } = new Collection<FeatureDto>();
    }
}
