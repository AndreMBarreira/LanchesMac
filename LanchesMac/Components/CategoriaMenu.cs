using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriRepository;

        public CategoriaMenu(ICategoriaRepository categoriRepository)
        {
            _categoriRepository = categoriRepository;
        }
        public IViewComponentResult Invoke() 
        {
            var categorias = _categoriRepository.Categorias.OrderBy(n => n.CategoriaNome);

            return View(categorias);
        }
    }
}
