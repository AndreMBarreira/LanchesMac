using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            //Essas linha foram comentadas pois foram substituidas por ViewModel
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria atual";
            ViewBag.Total = "Total de lanches : ";
            var totalLanches = lanchesListViewModel.Lanches.Count();
            ViewBag.TotalLanches = totalLanches;
            return View(lanchesListViewModel);
            //return View(lanches);
        }
    }
}
