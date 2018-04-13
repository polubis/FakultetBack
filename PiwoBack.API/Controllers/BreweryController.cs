using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PiwoBack.Services.Interfaces;

namespace PiwoBack.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BreweryController: Controller
    {
        private readonly IBreweryService _breweryService;

        public BreweryController(IBreweryService breweryService)
        {
            _breweryService = breweryService;
        }

        [HttpGet]
        public IActionResult GetBeers()
        {
            var breweries = _breweryService.GetAll();
            return Ok(breweries);
        }

        [HttpGet("{id}")]
        public IActionResult GetBrewery(int id)
        {
            var brewery = _breweryService.GetBrewery(id);
            if (brewery == null)
            {
                return NotFound();
            }
            return Ok(brewery);
        }

    }
}
