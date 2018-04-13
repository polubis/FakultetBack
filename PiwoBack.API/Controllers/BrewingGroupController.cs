using Microsoft.AspNetCore.Mvc;
using PiwoBack.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiwoBack.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BrewingGroupController: Controller
    {
        private readonly IBrewingGroupService _brewingGroupService;

        public BrewingGroupController(IBrewingGroupService brewingGroupService)
        {
            _brewingGroupService = brewingGroupService;
        }

        [HttpGet]
        public IActionResult GetBrewingGroups()
        {
            var brewingGroups = _brewingGroupService.GetAll();
            return Ok(brewingGroups);
        }

        [HttpGet("{id}")]
        public IActionResult GetBrewingGroup(int id)
        {
            var brewingGroup = _brewingGroupService.GetBrewingGroup(id);
            if (brewingGroup == null)
            {
                return NotFound();
            }
            return Ok(brewingGroup);
        }

    }
}
