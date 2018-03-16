using System.Web.Mvc;
using WebAppNinjectDemo.Models;

namespace WebAppNinjectDemo.Controllers
{
    public class HomeController : Controller
    {
        private ITime _time;
        public HomeController(ITime time)
        {
            _time = time;
        }

        public ActionResult Index()
        {
            string timeInfo = _time.InformacaoTime;
            return View(timeInfo as object);
        }
    }
}