using Catalog.API.Models.Genre;
using Catalog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenre_Service _genre_service;

        public GenreController(IGenre_Service genre_service)
        {
            _genre_service = genre_service;
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddGenre(string genre)
        {
            var result = await _genre_service.AddGenre(genre);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetGenreId(long id)
        {
            var result = await _genre_service.GetGenre(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGenre(GenreUpdate_Pass_Object genre)
        {
            var result = await _genre_service.UpdateGenre(genre.id, genre.genre);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }
    }
}
