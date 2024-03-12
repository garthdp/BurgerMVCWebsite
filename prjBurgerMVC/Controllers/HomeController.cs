using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using prjBurgerMVC.Models;
using prjFactoryConsole;
using System.Diagnostics;

namespace prjBurgerMVC.Controllers
{
    
    public class HomeController : Controller
    {
        BurgerFactory factory = new BurgerFactory();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PaymentComplete()
        {
            return View();
        }

        public IActionResult Burger()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Burger(string bType)
        {
            IBurger burger = factory.getBurger(bType);
            ViewBag.Message = burger.getImage();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(string id)
        {
            IBurger burger = factory.getBurger(id);
            ViewBag.Name = burger.getName();
            ViewBag.img = burger.getImage();
            ViewBag.Patty = burger.getPatty();
            ViewBag.Condiments = burger.getCondiments();
            ViewBag.Sauce = burger.getSauce();
            ViewBag.Price = burger.getPrice();
            return View(burger);
        }
    }
}
