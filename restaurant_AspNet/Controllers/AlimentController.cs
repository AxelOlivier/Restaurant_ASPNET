using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoApi.Data;
using RestoApi.models;

namespace RestoApi.Controllers
{
    [Route("aliments")]
    [ApiController]
    public class AlimentController : ControllerBase
    {
        private readonly DataContext _context;

        public AlimentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alimentaire>>> GetAliments()
        {
            return await _context.Alimentaire.ToListAsync();
        }


        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Alimentaire>> GetAliment(int id)
        {
            var aliment = await _context.Alimentaire.FindAsync(id);
            if (aliment == null)
            {
                return NotFound();
            }
            return aliment;
        }


        [HttpPost]
        public async Task<ActionResult> InsertAliment(Alimentaire aliment)
        {
            try
            {
                _context.Alimentaire.Add(aliment);
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
        public async Task<ActionResult> EditAliment(int id, Alimentaire alimentTmp)
        {
            if (id == alimentTmp.Id)
            {
                var aliment = await _context.Alimentaire.FindAsync(id);

                if (aliment == null)
                {
                    return NotFound();
                }

                aliment.Nom = alimentTmp.Nom;
                aliment.TypeAliment = alimentTmp.TypeAliment;

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
        public async Task<ActionResult> DeleteAliment(int id)
        {

            var aliment = await _context.Alimentaire.FindAsync(id);

            if (aliment == null)
            {
                return NotFound();
            }

            try
            {
                _context.Alimentaire.Remove(aliment);
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
