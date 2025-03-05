using KanBan.Services.Atividade;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace KanBan.Controllers
{
    public class AtividadeController : Controller
    {
        private readonly IAtividadeInterface _atividadeInterface;
        public AtividadeController(IAtividadeInterface atividadeInterface)
        {
            _atividadeInterface = atividadeInterface;
        }
        public async Task<IActionResult> Index()
        {
            var atividades = await _atividadeInterface.GetAtividades();
            return View(atividades);
        }
    }
}
