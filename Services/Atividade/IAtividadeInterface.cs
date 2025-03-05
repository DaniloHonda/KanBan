using KanBan.Dto;
using KanBan.Models;

namespace KanBan.Services.Atividade
{
    public interface IAtividadeInterface
    {
        Task<List<AtividadeModel>> GetAtividades();
        Task<List<StatusModel>> GetStatus();
        Task<AtividadeModel> AddAtividade(AddAtividadeDto atividadeNova);
    }
}
