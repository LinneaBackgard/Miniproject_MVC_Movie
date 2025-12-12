using System.Collections.Generic;
using System.Threading.Tasks;
using Miniproject_MVC_Movie.Models;

namespace Miniproject_MVC_Movie.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllAsync(string? q = null);
        Task<Movie?> GetByIdAsync(int id);
        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id); 
    }
}
