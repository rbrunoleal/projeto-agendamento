using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Service.Interfaces;
using System.Net;

namespace ProjetoServico.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ServicosController : ControllerBase
    {
        private readonly IServicoService _service;
        public ServicosController(IServicoService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodosServicos() {
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
        public async Task<ActionResult> InsereServico([FromBody] ServicoDto servico) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _service.Insere(servico);
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
        public async Task<ActionResult> AtualizaServico([FromBody] ServicoDto Servico) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            try {
                var result = await _service.Atualiza(Servico);
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
        public async Task<ActionResult> DeletaServico(Guid id) {
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
