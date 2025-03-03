using Microsoft.AspNetCore.Mvc;

namespace CadastroUserMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
