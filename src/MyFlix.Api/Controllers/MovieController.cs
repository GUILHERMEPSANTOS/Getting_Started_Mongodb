using Microsoft.AspNetCore.Mvc;
using MyFlix.Api.Contracts;
using MyFlix.Api.Services.Interfaces;

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
    public async Task<IActionResult> Create(MovieRequest request)
    {
        await _movieService.CreateMovieAsync(request);

        return Ok();
    }
}