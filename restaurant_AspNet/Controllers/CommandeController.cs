using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoApi.Data;
using RestoApi.models;


namespace RestoApi.Controllers
{
    [Route("commandes")]
    [ApiController]
    public class CommandeController : ControllerBase
    {
        private readonly DataContext _context;

        public CommandeController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commande>>> GetCommandes()
        {
            return await _context.Commande.ToListAsync();
        }


        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Commande>> GetCommande(int id)
        {
            var commande = await _context.Commande.FindAsync(id);
            if (commande == null)
            {
                return NotFound();
            }
            return commande;
        }


        [HttpPost]
        public async Task<ActionResult> InsertCommande(Commande commande)
        {
            try
            {
                _context.Commande.Add(commande);
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
        public async Task<ActionResult> EditCommande(int id, Commande commandeTmp)
        {
            if (id == commandeTmp.Id)
            {
                var commande = await _context.Commande.FindAsync(id);

                if (commande == null)
                {
                    return NotFound();
                }

                commande.Table = commandeTmp.Table;
                commande.Alimentaire= commandeTmp.Alimentaire;
                commande.Etat = commandeTmp.Etat;

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
        public async Task<ActionResult> DeleteCommande(int id)
        {

            var commande = await _context.Commande.FindAsync(id);

            if (commande == null)
            {
                return NotFound();
            }

            try
            {
                _context.Commande.Remove(commande);
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
