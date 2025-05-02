using GestaodeTarefasApi.Models;

namespace GestaodeTarefasApi.Data
{
    public interface ITarefasRepository
    {
        IEnumerable<Tarefa> GetAll();
        Tarefa GetById(int id);
        void Incluir(Tarefa tarefa);
        void Update(Tarefa tarefa);
        void Delete(Tarefa tarefa);
    }
}
