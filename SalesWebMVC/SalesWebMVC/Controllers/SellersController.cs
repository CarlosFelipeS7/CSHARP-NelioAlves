using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly ILogger<SellersController> _logger;

        private readonly DepartamentService _departamentService;

        public SellersController(SellerService sellerService, ILogger<SellersController> logger, DepartamentService departamentService)
        {
            _departamentService = departamentService;
            _sellerService = sellerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departaments = _departamentService.FindAll();
            ViewData["DepartamentId"] = new SelectList(departaments, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _logger.LogInformation("SellersController.Create [POST] called. ModelState.IsValid={IsValid}", ModelState.IsValid);

            if (!ModelState.IsValid)
            {
                var departaments = _departamentService.FindAll();
                ViewData["DepartamentId"] = new SelectList(departaments, "Id", "Name");
                return View(seller);
            }

            _logger.LogInformation("Inserting seller: Name={Name}, Email={Email}, BirthDate={BirthDate}, BaseSalary={BaseSalary}, DepartamentId={DeptId}",
                seller.Name, seller.Email, seller.BirthDate, seller.BaseSalary, seller.DepartamentId);

            _sellerService.Insert(seller);

            _logger.LogInformation("Insert completed for seller with Id={Id}", seller.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
