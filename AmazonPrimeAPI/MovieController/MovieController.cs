using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AmazonPrimeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonPrimeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { id = Guid.NewGuid(), name = "Harry Potter", duration = 2 },
            new Movie() { id = Guid.NewGuid(), name = "Jumanji", duration = 1 },
            new Movie() { id = Guid.NewGuid(), name = "Frozen", duration = 2 },
            new Movie() { id = Guid.NewGuid(), name = "Tres metros sobre el cielo", duration = 3 },
        };

        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie.id == Guid.Empty)
                movie.id = Guid.NewGuid();

            movies.Add(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            Movie currentMovie = movies.FirstOrDefault(m => m.id == movie.id);
            currentMovie.name = movie.name;
            currentMovie.duration = movie.duration;
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.id == id);
        }
    }
}