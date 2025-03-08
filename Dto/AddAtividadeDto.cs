using System.ComponentModel.DataAnnotations;

namespace KanBan.Dto
{
    public class AddAtividadeDto
    {
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Descricao é obrigatório")]
        public string Descricao { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage = "O campo Status é obrigatório")]
        public int StatusId { get; set; }
    }
}
