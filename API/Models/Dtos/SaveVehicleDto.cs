using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using API.Models.Entities;
using API.Models.Dtos;


namespace API.Models.Dtos
{
    public class SaveVehicleDto
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        [Required]
        public ContactDto? Contact { get; set; }
        public ICollection<int> Features { get; set; } = new Collection<int>();

    }
}