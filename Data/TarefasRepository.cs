using GestaodeTarefasApi.Models;

namespace GestaodeTarefasApi.Data
{
    public class TarefasRepository : ITarefasRepository
    {
        private readonly DataContext _context;

        public TarefasRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarefa> GetAll()
        {
            return [.. _context.Tarefas];
        }

        public Tarefa GetById(int id)
        {
            return _context.Tarefas.Find(id);
        }

        public void Incluir(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
        }

        public void Update(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
        }

        public void Delete(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
        }
    }
}
