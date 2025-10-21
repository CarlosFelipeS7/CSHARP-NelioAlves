using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;
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

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
        
            List<Departament> departaments = _departamentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departaments = departaments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SellerFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Departaments = _departamentService.FindAll();
                return View(viewModel);
            }

            try
            {
                _sellerService.Update(viewModel.Seller);
                return RedirectToAction(nameof(Index));
            }
            catch (SalesWebMVC.Services.Exceptions.NotFoundException)
            {
                return NotFound();
            }
            catch (SalesWebMVC.Services.Exceptions.DbConcurrencyException)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
