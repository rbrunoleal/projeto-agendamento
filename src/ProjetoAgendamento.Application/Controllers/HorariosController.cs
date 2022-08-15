using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Service.Interfaces;
using System.Net;

namespace ProjetoAgendamento.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class HorariosController : ControllerBase
    {
        private readonly IHorarioService _service;
        public HorariosController(IHorarioService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodosHorarios() {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            try {
                return Ok(await _service.BuscarTodos());
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
       
        [HttpPost]
        public async Task<ActionResult> InsereHorario([FromBody] HorarioDto Morador) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _service.Insere(Morador);
                if (result != null) {
                    return Ok(result);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> AtualizaHorario([FromBody] HorarioDto Morador) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _service.Atualiza(Morador);
                if (result != null) {
                    return Ok(result);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletaHorario(Guid id) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                return Ok(await _service.Deleta(id));
            }
            catch (ArgumentException ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }

}
