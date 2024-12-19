using Microsoft.AspNetCore.Mvc;
using MyFlix.Api.Contracts;
using MyFlix.Api.Services.Interfaces;
using Myflix.Domain;

namespace MyFlix.Api.Controllers;

[ApiController]
[Route("movies")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(NewMovieRequest request)
    {
        await _movieService.CreateMovieAsync(request);

        return Ok();
    }

    [HttpGet("{id_movie}")]
    public async Task<IActionResult> GetMovieByIdAsync(Guid id_movie)
    {
        var movie = await _movieService.GetMovieByIdAsync(id_movie);
        return Ok(movie);
    }

    [HttpPost("release-date/after/{releaseDate}")]
    public async Task<IActionResult> GetMoviesWithReleaseDateAfter(DateTime releaseDate)
    {
        var movies = await _movieService.GetMoviesWithReleaseDateAfter(releaseDate);
        return Ok(movies);
    }
}