using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MazeApi.Models;

namespace MazeOfSecrets_WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MazeDataItemsController : ControllerBase
    {
        private readonly MazeDataContext _context;

        public MazeDataItemsController(MazeDataContext context)
        {
            _context = context;
        }

        // GET: api/MazeDataItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MazeDataItem>>> GetMazeDatas()
        {
            return await _context.MazeDataItems.ToListAsync();
        }

        // GET: api/MazeDataItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MazeDataItem>> GetMazeDataItem(int id)
        {
            var mazeDataItem = await _context.MazeDataItems.FindAsync(id);

            if (mazeDataItem == null)
            {
                return NotFound();
            }

            return mazeDataItem;
        }

        // PUT: api/MazeDataItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMazeDataItem(int id, MazeDataItem mazeDataItem)
        {
            if (id != mazeDataItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(mazeDataItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MazeDataItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MazeDataItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MazeDataItem>> PostMazeDataItem(MazeDataItem mazeDataItem)
        {
            _context.MazeDataItems.Add(mazeDataItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMazeDataItem), new { id = mazeDataItem.Id }, mazeDataItem);
        }

        // DELETE: api/MazeDataItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MazeDataItem>> DeleteMazeDataItem(long id)
        {
            var mazeDataItem = await _context.MazeDataItems.FindAsync(id);
            if (mazeDataItem == null)
            {
                return NotFound();
            }

            _context.MazeDataItems.Remove(mazeDataItem);
            await _context.SaveChangesAsync();

            return mazeDataItem;
        }

        private bool MazeDataItemExists(int id)
        {
            return _context.MazeDataItems.Any(e => e.Id == id);
        }
    }
}
