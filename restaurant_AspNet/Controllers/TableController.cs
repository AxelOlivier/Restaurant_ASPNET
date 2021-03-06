using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoApi.Data;
using RestoApi.models;

namespace RestoApi.Controllers
{
    [Route("tables")]
    [ApiController]
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
            return await _context.Table.ToListAsync();
        }

        
        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Table>> GetTable(int id)
        {
            var table = await _context.Table.FindAsync(id);
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
                _context.Table.Add(table);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return NotFound();
            }

            return Ok();
        }


        [Route("{id}")]
        [HttpPut]
        public async Task<ActionResult> EditTable(int id, Table tableTmp)
        {
            if (id == tableTmp.Id)
            {
                var table = await _context.Table.FindAsync(id);
                
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
            return Ok();
        }


        [Route("{id}")]
        [HttpDelete]
        public async Task<ActionResult> DeleteTable(int id)
        {
            
            var table = await _context.Table.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            try
            {
                _context.Table.Remove(table);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
