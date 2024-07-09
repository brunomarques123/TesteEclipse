using AutoMapper;
using TesteEclipse.Data.Repositories;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.Services
{


    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IMapper _mapper;

        public ProjetoService(IProjetoRepository projetoRepository, IMapper mapper)
        {
            _projetoRepository = projetoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProjetoDTO>> ListarProjetosPorUsuario(int idUsuario)
        {
            var projetos = await _projetoRepository.ListarProjetosPorUsuario(idUsuario);
            return _mapper.Map<IEnumerable<ProjetoDTO>>(projetos);
        }

        public async Task<ProjetoDTO> ObterProjetoPorId(int id)
        {
            var projeto = await _projetoRepository.ObterPorId(id);
            return _mapper.Map<ProjetoDTO>(projeto);
        }

        public async Task AdicionarProjeto(ProjetoDTO projetoDTO)
        {
            var projeto = _mapper.Map<Projeto>(projetoDTO);
            await _projetoRepository.Adicionar(projeto);
        }

        public async Task AtualizarProjeto(ProjetoDTO projetoDTO)
        {
            var projeto = _mapper.Map<Projeto>(projetoDTO);
            await _projetoRepository.Atualizar(projeto);
        }

        public async Task RemoverProjeto(int id)
        {
            var projeto = await _projetoRepository.ObterPorId(id);
            if (projeto != null)
            {
                await _projetoRepository.Remover(projeto);
            }
        }
    }
}


