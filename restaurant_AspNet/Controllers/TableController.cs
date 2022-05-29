using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoApi.Data;
using RestoApi.models;

namespace RestoApi.Controllers
{
    [ApiController]
    [Route("tables")]
    public class TableController : ControllerBase
    {
        private readonly DataContext _context;

        public TableController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table>>> GetTables()
        {
            return await _context.Tables.ToListAsync();
        }


        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Table>> GetTable(int id)
        {
            var table = await _context.Tables.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }
            return table;
        }

        [HttpPost]
        public async Task<ActionResult> InsertTable(Table table)
        {
            try
            {
                _context.Tables.Add(table);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetTables));
            }
            catch
            {
                return null;
            }
        }

        [Route("{id}")]
        [HttpPut]
        public async Task<ActionResult> EditTable(int id, Table tableTmp)
        {
            if (id == tableTmp.Id)
            {
                var table = await _context.Tables.FindAsync(id);

                if (table == null)
                {
                    return NotFound();
                }

                table.NumTable = tableTmp.NumTable;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch
                {
                    return NotFound();
                }
            }
            return RedirectToAction(nameof(GetTables));
        }
    }
}