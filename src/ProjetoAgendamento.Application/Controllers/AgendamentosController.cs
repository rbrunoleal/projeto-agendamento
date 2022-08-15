﻿using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Domain.DTOs;
using ProjetoAgendamento.Service.Interfaces;
using System.Net;

namespace ProjetoAgendamento.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class AgendamentosController : ControllerBase
    {
        private readonly IAgendamentoService _service;
        public AgendamentosController(IAgendamentoService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodosAgendamentos() {
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
        public async Task<ActionResult> InsereAgendamento([FromBody] AgendamentoDto Morador) {
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
        public async Task<ActionResult> AtualizaAgendamento([FromBody] AgendamentoDto Morador) {
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
        public async Task<ActionResult> DeletaAgendamento(Guid id) {
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