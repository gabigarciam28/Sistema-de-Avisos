using System.Web.Mvc;

namespace WebServiceAltamira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Página de Inicio";

            return View();
        }
    }
}
