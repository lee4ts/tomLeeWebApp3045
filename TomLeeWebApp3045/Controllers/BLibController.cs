/*
@TODO:
Controller should have the following methods:
1) Show the view, apply initial filters? combine 1 and 2?
2) Retrieve from database and show the view (refresh or apply filters)
3) Send to add view and another for the add action
4) Send to edit view and another for the edit action
5) Show delete dialog and another for the delete action
6) Some thing for filtering and searching? Might need model? Use JS Dialog?
- pull from the categories repo. category name isn't nullable. Have a default category of uncategorized.
7) error handling and logging
*/

using Microsoft.AspNetCore.Mvc;
using TomLeeWebApp3045.Models;
using TomLeeWebApp3045.Data;
using TomLeeWebApp3045.Interfaces;

namespace TomLeeWebApp3045.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BLibController : ControllerBase
    {
        private readonly ILogger<BLibController> _logger;
        private readonly IBLibContextDAO _context;

        public BLibController(ILogger<BLibController> logger, IBLibContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllBLibs());
        }

        [HttpGet]
        public IActionResult Get(List<int> ids)
        {
            var bLib = _context.GetBLibsByIDs(ids);
            if (bLib == null)
            {
                return NotFound();
            }
            return Ok(bLib);
        }

    }
}