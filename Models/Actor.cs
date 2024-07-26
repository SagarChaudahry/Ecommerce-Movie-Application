using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Actor
    {

        public int Id { get; set; }

        [Display(Name ="Profile Pic")]
        [Required(ErrorMessage ="Profile pic is required")]
        public string Profile { get; set; }

        [Display(Name ="FirstName")]
        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }

        [Display(Name ="LastName")]
        [Required(ErrorMessage ="LastName is required")]
        public string LastName { get; set; }

        [Display(Name ="Bio")]
        [Required(ErrorMessage ="Bio is required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
