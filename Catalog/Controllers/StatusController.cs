using Catalog.API.Models.Status;
using Catalog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatus_Service _status_service;

        public StatusController(IStatus_Service status_service)
        {
            _status_service = status_service;
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> AddStatus(string name)
        {
            var result = await _status_service.AddStatus(name);
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
        public async Task<IActionResult> GetStatusId(long id)
        {
            var result = await _status_service.GetStatus(id);
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
        public async Task<IActionResult> UpdateStatus(StatusUpdate_Pass_Object status)
        {
            var result = await _status_service.UpdateStatus(status.id, status.name);
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
