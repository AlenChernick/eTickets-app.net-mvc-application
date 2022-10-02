using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 12 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        [StringLength(200, MinimumLength = 15, ErrorMessage = "Biography must be between 15 and 200 chars")]
        public string Bio { get; set; }

        //Realtionships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
