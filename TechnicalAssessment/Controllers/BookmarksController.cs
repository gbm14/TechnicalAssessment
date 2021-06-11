using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechnicalAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookmarksController : ControllerBase
    {
        private readonly BookmarksContext _context;

        private readonly ILogger<BookmarksController> _logger;

        public BookmarksController(BookmarksContext context, ILogger<BookmarksController> logger)
        {
            _context = context;
            _logger = logger;
        }

        #region snippet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bookmarks>>> GetTodoItems()
        {
            return await _context.Bookmarks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bookmarks>> GetBookmark(long id)
        {
            var bookmark = await _context.Bookmarks.FindAsync(id);

            if (bookmark == null)
            {
                return NotFound();
            }

            return bookmark;
        }

        #endregion snippet
    }
}
