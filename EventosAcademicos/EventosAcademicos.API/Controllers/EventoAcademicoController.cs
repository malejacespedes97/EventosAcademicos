using EventosAcademicos.API.Data;
using EventosAcedemicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace EventoAcademicoController.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// Habilita el endpoint del controlador
    public class EventoAcademicoController : Controller
    {
        private readonly DataContext _context;

        public EventoAcademicoController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.EventosAcademicos.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var EventoAcademico = await _context.EventosAcademicos.FirstOrDefaultAsync(x => x.Id == id);
            if (EventoAcademico == null)
            {
                return NotFound();
            }
            return Ok(EventoAcademico);
        }


        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(EventoAcademico eventoAcademico)
        {

            _context.Update(eventoAcademico);
            await _context.SaveChangesAsync();
            return Ok(eventoAcademico);
        }

        [HttpPost]
        public async Task<ActionResult> Post(EventoAcademico EventosAcademico) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(EventosAcademico);
            await _context.SaveChangesAsync();
            return Ok(EventosAcademico);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.EventosAcademicos
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