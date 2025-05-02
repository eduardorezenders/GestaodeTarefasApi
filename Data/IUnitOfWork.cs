namespace GestaodeTarefasApi.Data
{
    public interface IUnitOfWork
    {
        ITarefasRepository Tarefas { get; }
        Task<int> CompleteAsync();
    }
}
