namespace GestaodeTarefasApi.Data
{
    public class UnitOfWork(DataContext context) : IUnitOfWork
    {
        private DataContext _context = context;
        private ITarefasRepository? _tarefaRepository;

        public ITarefasRepository Tarefas
        {
            get
            {
                _tarefaRepository ??= new TarefasRepository(_context);

                return _tarefaRepository;
            }
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();
    }
}
