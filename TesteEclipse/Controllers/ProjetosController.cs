using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteEclipse.DTOs;
using TesteEclipse.Services;

namespace TesteEclipse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetosController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<ProjetoDTO>>> ListarProjetosPorUsuario(int idUsuario)
        {
            try
            {
                var projetos = await _projetoService.ListarProjetosPorUsuario(idUsuario);
                return Ok(projetos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao listar projetos: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjetoDTO>> ObterProjetoPorId(int id)
        {
            try
            {
                var projeto = await _projetoService.ObterProjetoPorId(id);
                if (projeto == null)
                {
                    return NotFound($"Projeto com id {id} não encontrado");
                }
                return Ok(projeto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao obter projeto: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarProjeto([FromBody] ProjetoDTO projetoDTO)
        {
            try
            {
                await _projetoService.AdicionarProjeto(projetoDTO);
                return Ok("Projeto adicionado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar projeto: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarProjeto(int id, [FromBody] ProjetoDTO projetoDTO)
        {
            try
            {
                if (id != projetoDTO.Id)
                {
                    return BadRequest("Ids informados não correspondem");
                }

                await _projetoService.AtualizarProjeto(projetoDTO);
                return Ok("Projeto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar projeto: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverProjeto(int id)
        {
            try
            {
                await _projetoService.RemoverProjeto(id);
                return Ok("Projeto removido com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao remover projeto: {ex.Message}");
            }
        }
    }
}
