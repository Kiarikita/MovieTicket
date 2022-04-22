using eBiletix.Data.Base;
using eBiletix.Data.ViewModels;
using eBiletix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<Movie> //generic --> sabit değil
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);

        Task UpdateMovieAsync(NewMovieVM data);

    }
}
