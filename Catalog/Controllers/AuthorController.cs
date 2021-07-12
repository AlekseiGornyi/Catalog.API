using Catalog.API.Models.Author;
using Catalog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthor_Service _author_service;

        public AuthorController(IAuthor_Service author_service)
        {
            _author_service = author_service ?? throw new ArgumentNullException(nameof(author_service)); 
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddAuthor(string name, string aboutAuthor)
        {            
            var result = await _author_service.AddAuthor(name, aboutAuthor);
            if(result!= null)
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
        public async Task<IActionResult> GetAuthourId(long id)
        {
            var result = await _author_service.GetAuthor(id);
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
        public async Task<IActionResult> UpdateAuthour(AuthorUpdate_Pass_Object author)
        {
            var result = await _author_service.UpdateAuthor(author.id, author.name, author.aboutAuthor);
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
