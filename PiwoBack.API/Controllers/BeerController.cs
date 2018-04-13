using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiwoBack.Services.Interfaces;

namespace PiwoBack.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BeerController : Controller
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public IActionResult GetBeers()
        {
            var beers = _beerService.GetAll();
            return Ok(beers);
        }

        [HttpGet("{id}")]
        public IActionResult GetBeer(int id)
        {
            var beer = _beerService.GetBeer(id);
            if(beer == null)
            {
                return NotFound();
            }
            return Ok(beer);
        }
    }
}