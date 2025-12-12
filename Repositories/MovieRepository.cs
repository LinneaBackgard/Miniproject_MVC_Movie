using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miniproject_MVC_Movie.Data;
using Miniproject_MVC_Movie.Models;

namespace Miniproject_MVC_Movie.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. Hämta alla filmer
        public async Task<IEnumerable<Movie>> GetAllAsync(string? q = null)
        {
            var query = _context.Movie.AsQueryable();

            if (!string.IsNullOrWhiteSpace(q))
            {
                q = q.Trim();

                query = query.Where(m =>
                    m.Title.Contains(q) ||
                    m.Genre.Contains(q));
            }

            return await query.ToListAsync();
        }


        // 2. Hämta en film på id
        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
        }

        // 3. Lägg till en ny film
        public async Task AddAsync(Movie movie)
        {
            await _context.Movie.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        // 4. Uppdatera en befintlig film
        public async Task UpdateAsync(Movie movie)
        {
            _context.Movie.Update(movie);
            await _context.SaveChangesAsync();
        }

        // 5. Ta bort en film
        public async Task DeleteAsync(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }

        // 6. Kolla om film med visst id finns
        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Movie.AnyAsync(m => m.Id == id);
        }
    }
}
