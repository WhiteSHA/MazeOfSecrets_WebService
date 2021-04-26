using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // GET: api/MazeDataItems/GetCount
        [HttpGet("GetCount")]
        public int GetCount()
        {
            return _context.MazeDataItems.ToList().Count;
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

        // GET: api/MazeDataItems/GetByUser/
        [HttpGet("GetByUser/{userId}")]
        public List<MazeDataItem> GetMazeDataItemsByUserAsync(int userId)
        {
            List<MazeDataItem> items = _context.MazeDataItems.ToList();            

            if (items == null)
            {
                return null;
            }

            List<MazeDataItem> itemsToSend = new List<MazeDataItem>();
            for (int i = 0; i < items.Count; ++i)
            {
                if (items[i].UserId == userId)
                    itemsToSend.Add(items[i]);
            }

            return itemsToSend;
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
        public async Task<ActionResult<MazeDataItem>> DeleteMazeDataItem(int id)
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

        // DELETE: api/MazeDataItems/DeleteAllItems
        [HttpDelete("DeleteAllItems")]
        public int DeleteMazeDataItems() // not workings
        {
            foreach(var entity in _context.MazeDataItems)
                _context.MazeDataItems.Remove(entity);
            _context.SaveChanges();

            return _context.MazeDataItems.ToList().Count();
        }

        private bool MazeDataItemExists(int id)
        {
            return _context.MazeDataItems.Any(e => e.Id == id);
        }
    }
}
