using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grupparbete.Data;
using Grupparbete.Models;
using Microsoft.AspNetCore.Authorization;

namespace Grupparbete.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PizzasController : ControllerBase
    {
        private readonly MvcPizzaContext _context;

        public PizzasController(MvcPizzaContext context)
        {
            _context = context;
        }

        // GET: api/Pizzas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizzas>>> GetPizzas()
        {
            return await _context.Pizzas.ToListAsync();
        }

        // GET: api/Pizzas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pizzas>> GetPizzas(int id)
        {
            var pizzas = await _context.Pizzas.FindAsync(id);

            if (pizzas == null)
            {
                return NotFound();
            }

            return pizzas;
        }

        // PUT: api/Pizzas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizzas(int id, Pizzas pizzas)
        {
            if (id != pizzas.Id)
            {
                return BadRequest();
            }

            _context.Entry(pizzas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzasExists(id))
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

        // POST: api/Pizzas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pizzas>> PostPizzas(Pizzas pizzas)
        {
            _context.Pizzas.Add(pizzas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPizzas", new { id = pizzas.Id }, pizzas);
        }

        // DELETE: api/Pizzas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizzas(int id)
        {
            var pizzas = await _context.Pizzas.FindAsync(id);
            if (pizzas == null)
            {
                return NotFound();
            }

            _context.Pizzas.Remove(pizzas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PizzasExists(int id)
        {
            return _context.Pizzas.Any(e => e.Id == id);
        }
    }
}
