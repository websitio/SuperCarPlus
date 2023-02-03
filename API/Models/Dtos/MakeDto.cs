using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Models.Dtos
{
    public class MakeDto{
        public int 
        Id { get; set; }


        public string? 
        Name { get; set; }
        
        public ICollection<ModelDto>   Models { get; set; }  = new Collection<ModelDto>();
        
    }
}