namespace KanBan.Dto
{
    public class AddAtividadeDto
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int StatusId { get; set; }
    }
}
