using Microsoft.AspNetCore.Mvc;
using GestaodeTarefasApi.Data;
using GestaodeTarefasApi.Models;

namespace GestaodeTarefasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TarefasController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;


        [HttpGet("pesquisar/tudo")]
        public ActionResult<IEnumerable<Tarefa>> PesquisarTarefas() => _unitOfWork.Tarefas.GetAll().ToList();

        [HttpGet("pesquisar/por/id/{id}")]
        public ActionResult<Tarefa> PesquisarTarefa(int id)
        {
            Tarefa tarefa = _unitOfWork.Tarefas.GetById(id);

            if (tarefa == null)
                return NotFound($"Nenhum registro encontrado para o ID: {id}");

            return tarefa;
        }


        [HttpPost("incluir")]
        public async Task<ActionResult<Tarefa>> IncluirTarefa(Tarefa tarefa)
        {
            _unitOfWork.Tarefas.Incluir(tarefa);
            await _unitOfWork.CompleteAsync();

            return CreatedAtAction(nameof(PesquisarTarefa), new { id = tarefa.Id }, tarefa);
        }


        [HttpPut("alterar/{id}")]
        public async Task<IActionResult> AlterarTarefa(int id, Tarefa tarefa)
        {
            if (id != tarefa.Id)
                return BadRequest($"ID deve ser informado!");

            Tarefa existingTarefa = _unitOfWork.Tarefas.GetById(id);
            if (existingTarefa == null)
            {
                return NotFound($"{id} não encontrado!");
            }

            _unitOfWork.Tarefas.Update(tarefa);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }


        [HttpDelete("remover/{id}")]
        public async Task<IActionResult> RemoverTarefa(int id)
        {
            Tarefa? tarefa = _unitOfWork.Tarefas.GetById(id);
            if (tarefa == null)
                return NotFound($"Nenhum registro encontrado para o ID: {id}!");

            _unitOfWork.Tarefas.Delete(tarefa);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
