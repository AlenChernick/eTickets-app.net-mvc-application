using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema Logo is required.")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required.")]
        [StringLength(22, MinimumLength = 4, ErrorMessage = "Cinema Name must be between 4 and 22 chars")]
        public string Name { get; set; }

        [Display(Name = "Cinema Description")]
        [Required(ErrorMessage = "Cinema Description is required.")]
        [StringLength(200, MinimumLength = 15, ErrorMessage = "Cinema Description must be between 15 and 200 chars")]
        public string Description { get; set; }

        //Realtionships
        public List<Movie> Movies { get; set; }
    }
}
