
using EventosAcademicos.API.Data;
using EventosAcedemicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace EventoAcademicoController.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// Habilita el endpoint del controlador
    public class ParticipanteController : Controller
    {
        private readonly DataContext _context;

        public ParticipanteController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Participantes.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var Participante = await _context.Participantes.FirstOrDefaultAsync(x => x.Id == id);
            if (Participante == null)
            {
                return NotFound();
            }
            return Ok(Participante);
        }


        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Participante participante)
        {

            _context.Update(participante);
            await _context.SaveChangesAsync();
            return Ok(participante);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Participante participante) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(participante);
            await _context.SaveChangesAsync();
            return Ok(participante);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Participantes
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