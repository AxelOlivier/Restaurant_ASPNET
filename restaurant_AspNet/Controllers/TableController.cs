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
        private readonly IDataContext _context;
        private readonly ILogger<TableController> _logger;

        public TableController(ILogger<TableController> logger,
            IDataContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        [HttpGet]
        public async Task<IEnumerable<Table>> GetTables()
        {
            return null; //await _context.Tables.ToListAsync();
        }

        /*
        [Route("{id}")]
        [HttpGet]
        public Table GetTable(int id)
        {
            return null;
        }

        [Route("create")]
        [HttpPost]
        public ActionResult InsertTable(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetTables));
            }
            catch
            {
                return null;
            }
        }

        [Route("update/{id}")]
        [HttpPut]
        public ActionResult EditTable(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetTables));
            }
            catch
            {
                return null;
            }
        }

        [Route("delete/{id}")]
        [HttpPut]
        public ActionResult DeleteTable(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetTables));
            }
            catch
            {
                return null;
            }
        }
        */
    }
}
