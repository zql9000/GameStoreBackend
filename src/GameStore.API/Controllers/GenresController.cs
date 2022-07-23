using GameStore.Application.DTOs;
using GameStore.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/<GenresController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GenreDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<GenreDto> Get()
        {
            var genres = _genreService.GetAll();
            return genres;
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenreDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GenreDto> Get(int id)
        {
            var genre = _genreService.GetById(id);

            if (genre is null) return NotFound();

            return genre;
        }

        // POST api/<GenresController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GenreDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] GenreDto genre)
        {
            var newGenre = await _genreService.Create(genre);
            return StatusCode(StatusCodes.Status201Created, newGenre);
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
