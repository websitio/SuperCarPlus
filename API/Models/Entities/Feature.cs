using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Models.Entities;

namespace API.Models.Entities
{
    [Table("Features")]
    public class Feature
    {
         public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string? Name { get; set; }

       // public ICollection<Vehicle> Vehicles {get; set;} = new List<Vehicle>();


    }
}