﻿using KanBan.Dto;
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
        public async Task<IActionResult> Cadastrar()
        {
            var status = await _atividadeInterface.GetStatus();
            ViewBag.Status = status;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(AddAtividadeDto novaAtividade)
        {
            if (ModelState.IsValid) // Verifica se required esta sendo respeitado
            {
                var atividade = await _atividadeInterface.AddAtividade(novaAtividade);
                return RedirectToAction("Index");
            }
            else
            {
                var status = await _atividadeInterface.GetStatus();
                ViewBag.Status = status;
                return View(novaAtividade);
            }
        }
    }
}
