using Microsoft.EntityFrameworkCore;
using GestaodeTarefasApi.Models;

namespace GestaodeTarefasApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
