using System.ComponentModel.DataAnnotations;

namespace GestaodeTarefasApi.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "O título é obrigatório.")]
        public required string Titulo { get; set; }

        public required string Descricao { get; set; }

        //[Required(ErrorMessage = "O status é obrigatório.")]
        public StatusTarefa Status { get; set; }

        public DateTime DataVencimento { get; set; }
    }

    public enum StatusTarefa
    {
        Pendente,
        EmAndamento,
        Concluido
    }
}
