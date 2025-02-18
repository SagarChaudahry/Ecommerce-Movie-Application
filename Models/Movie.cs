﻿using movieTickets.Data.Enum;

namespace movieTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price  { get; set; }
        public string? ImageURL { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie>? Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }


    }
}
