﻿using Common.Contracts;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppFlix.Services
{
    public class MovieService : IMovieService
    {
        private const string API_BASE_URL = "YOUR_API_URL_HERE";
        IMovieApi _movieApi;

        public MovieService()
        {
            _movieApi = RestService.For<IMovieApi>(API_BASE_URL);
        }

        public Task<MovieDetails> GetMovieDetails(string id)
        {
            return _movieApi.GetMovieDetails(id);
        }

        public Task<IEnumerable<MovieSummary>> GetMovies()
        {
            return _movieApi.GetMovies();
        }
    }
}