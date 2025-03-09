using KanBan.Dto;
using KanBan.Models;

namespace KanBan.Services.Atividade
{
    public interface IAtividadeInterface
    {
        Task<List<AtividadeModel>> GetAtividades();
        Task<List<StatusModel>> GetStatus();
        Task<AtividadeModel> AddAtividade(AddAtividadeDto atividadeNova);
        Task<AtividadeModel> MudarCard(int atividadeId);
        Task<AtividadeModel> DeletarCard(int atividadeId);
        Task<AtividadeModel> VoltarCard(int atividadeId);

    }
}
