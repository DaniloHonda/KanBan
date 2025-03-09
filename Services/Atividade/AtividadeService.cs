using KanBan.Data;
using KanBan.Dto;
using KanBan.Models;
using Microsoft.EntityFrameworkCore;

namespace KanBan.Services.Atividade
{
    public class AtividadeService : IAtividadeInterface
    {
        private readonly AppDbContext _context;
        public AtividadeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<AtividadeModel> AddAtividade(AddAtividadeDto atividadeNova)
        {
            try
            {
                Random random = new Random();
                var atividade = new AtividadeModel()
                {
                    Matricula = random.Next(1000, 9999),
                    Titulo = atividadeNova.Titulo,
                    Descricao = atividadeNova.Descricao,
                    StatusId = atividadeNova.StatusId,
                    DataCriacao = atividadeNova.DataCriacao
                };
                _context.Atividade.Add(atividade);
                await _context.SaveChangesAsync();
                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel> MudarCard(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividade.FindAsync(atividadeId);

                if (atividade.StatusId < 4 && atividade.StatusId > 0 && atividade != null)
                {
                    atividade.StatusId++;
                }

                _context.Update(atividade);
                await _context.SaveChangesAsync();
                return atividade;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<AtividadeModel> DeletarCard(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividade.FindAsync(atividadeId);
                _context.Remove(atividade);
                await _context.SaveChangesAsync();
                return atividade;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<AtividadeModel>> GetAtividades()
        {
            try
            {
                var atividades = await _context.Atividade.Include(x => x.Status).ToListAsync();

                return atividades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StatusModel>> GetStatus()
        {
            try
            {
                var status = await _context.Status.ToListAsync();
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel> VoltarCard(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividade.FindAsync(atividadeId);

                if (atividade.StatusId > 1)
                {
                    atividade.StatusId--;
                }

                _context.Update(atividade);
                await _context.SaveChangesAsync();
                return atividade;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
