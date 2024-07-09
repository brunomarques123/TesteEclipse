using Microsoft.AspNetCore.Mvc;
using TesteEclipse.DTOs;
using TesteEclipse.Services;

namespace TesteEclipse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefasController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet("projeto/{idProjeto}")]
        public async Task<ActionResult<IEnumerable<TarefaDTO>>> ListarTarefasPorProjeto(int idProjeto)
        {
            try
            {
                var tarefas = await _tarefaService.ListarTarefasPorProjeto(idProjeto);
                return Ok(tarefas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao listar tarefas: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaDTO>> ObterTarefaPorId(int id)
        {
            try
            {
                var tarefa = await _tarefaService.ObterTarefaPorId(id);
                if (tarefa == null)
                {
                    return NotFound($"Tarefa com id {id} não encontrada");
                }
                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao obter tarefa: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarTarefa([FromBody] TarefaDTO tarefaDTO)
        {
            try
            {
                await _tarefaService.AdicionarTarefa(tarefaDTO);
                return Ok("Tarefa adicionada com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar tarefa: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarTarefa(int id, [FromBody] TarefaDTO tarefaDTO)
        {
            try
            {
                if (id != tarefaDTO.Id)
                {
                    return BadRequest("Ids informados não correspondem");
                }

                await _tarefaService.AtualizarTarefa(tarefaDTO);
                return Ok("Tarefa atualizada com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar tarefa: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverTarefa(int id)
        {
            try
            {
                await _tarefaService.RemoverTarefa(id);
                return Ok("Tarefa removida com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao remover tarefa: {ex.Message}");
            }
        }
    }
}
