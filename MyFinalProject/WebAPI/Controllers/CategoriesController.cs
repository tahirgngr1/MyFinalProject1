using Businnes.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoyService;

        public CategoriesController(ICategoryService categoyService)
        {
            _categoyService = categoyService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoyService.GetAll();
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
