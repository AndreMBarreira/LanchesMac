using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return $"Testando o metodo Index de AdminController : {DateTime.Now} ";
        }
        public string Demo()
        {
            return $"Testando o metodo Demo de AdminController : {DateTime.Now} ";
        }
    }
}
