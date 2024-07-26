using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        [Display(Name="Cinema logo")]
        public string? Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }

}
