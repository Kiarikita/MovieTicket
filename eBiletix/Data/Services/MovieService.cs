using eBiletix.Data.Base;
using eBiletix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(ao => ao.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n=> n.Id == id);

            return movieDetails;
        }
    }
}
