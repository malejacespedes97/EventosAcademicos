using Microsoft.AspNetCore.Mvc;
using EventosAcedemicos.Shared.Entities;
using EventosAcademicos.API.Data;
using Microsoft.EntityFrameworkCore;

namespace EventosAcademicos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramaEventoController : ControllerBase
    {
        private readonly DataContext _context;

        public ProgramaEventoController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProgramaEventos.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var programaEvento = await _context.ProgramaEventos.FirstOrDefaultAsync(x => x.Id == id);
            if (programaEvento == null)
            {
                return NotFound();
            }
            return Ok(programaEvento);
        }


        [HttpPost]
        public async Task<ActionResult> Post(ProgramaEvento programaEvento) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(programaEvento);
            await _context.SaveChangesAsync();
            return Ok(programaEvento);
        }


        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(ProgramaEvento programaEvento)
        {

            _context.Update(programaEvento);
            await _context.SaveChangesAsync();
            return Ok(programaEvento);
        }

        // Borrar-- delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.ProgramaEventos
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }   

            return NoContent();
        }
    }
}
