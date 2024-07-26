using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Producer
    {
        public int Id { get; set; }

        [Display(Name ="Profile pic")]
        public string? Profile { get; set; }

        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        [Display(Name = "Bio")]
        public string? Bio { get; set; }

        //Relationship
        public List<Movie> Movies{ get; set; }
    }
}
