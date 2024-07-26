using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public interface IActorsService
    {
        //Method to get all actors from database 
        Task<IEnumerable<Actor>> GetAllAsync();

        //Method to get a specific actor by ID
        Task<Actor> GetByIdAsync(int id);

        //Method to add a new actor
        Task AddAsync(Actor actor);

        //Method to Update an existing actor
       Task<Actor> UpdateAsync(int id, Actor newActor);

        //Method to delete an actor by ID
        Task DeleteAsync(int id);

    }
}
