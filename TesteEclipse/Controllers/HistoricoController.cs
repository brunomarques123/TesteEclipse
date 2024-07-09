using Microsoft.AspNetCore.Mvc;
using TesteEclipse.DTOs;
using TesteEclipse.Services;

namespace TesteEclipse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoricoController : ControllerBase
    {
        private readonly IHistoricoService _historicoService;

        public HistoricoController(IHistoricoService historicoService)
        {
            _historicoService = historicoService;
        }

        [HttpGet("tarefa/{idTarefa}")]
        public async Task<ActionResult<IEnumerable<HistoricoDTO>>> ListarHistoricoPorTarefa(int idTarefa)
        {
            try
            {
                var historico = await _historicoService.ListarHistoricoPorTarefa(idTarefa);
                return Ok(historico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao listar histórico: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarHistorico([FromBody] HistoricoDTO historicoDTO)
        {
            try
            {
                await _historicoService.AdicionarHistorico(historicoDTO);
                return Ok("Histórico adicionado com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar histórico: {ex.Message}");
            }
        }
    }
}