using System.ComponentModel.DataAnnotations;


namespace API.Models.Dtos
{
   public class ContactDto
    {
        [Required]
        [StringLength(32,6)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        [Required]
        [StringLength(255)]
        public string? Phone { get; set; }


        
    }
}