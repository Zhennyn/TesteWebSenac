using Microsoft.AspNetCore.Mvc;

namespace TesteWeb.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
