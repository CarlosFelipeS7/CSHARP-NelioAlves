            using Microsoft.AspNetCore.Mvc;
            using Microsoft.AspNetCore.Mvc.Rendering;
            using Microsoft.Extensions.Logging;
            using SalesWebMVC.Models;
            using SalesWebMVC.Models.ViewModels;
            using SalesWebMVC.Services;
            using System.Diagnostics;
            using System.Collections.Generic;
            using System.Threading.Tasks;

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

                    public async Task<IActionResult> Index()
                    {
                        var list = await _sellerService.FindAllAsync();
                        return View(list);
                    }

                    public async Task<IActionResult> Create()
                    {
                        var departaments = await _departamentService.FindAllAsync();
                        ViewData["DepartamentId"] = new SelectList(departaments, "Id", "Name");
                        return View();
                    }

                    [HttpPost]
                    [ValidateAntiForgeryToken]
                    public async Task<IActionResult> Create(Seller seller)
                    {
                        _logger.LogInformation("SellersController.Create [POST] called. ModelState.IsValid={IsValid}", ModelState.IsValid);

                        if (!ModelState.IsValid)
                        {
                            var departaments = await _departamentService.FindAllAsync();
                            ViewData["DepartamentId"] = new SelectList(departaments, "Id", "Name");
                            return View(seller);
                        }

                        _logger.LogInformation("Inserting seller: Name={Name}, Email={Email}, BirthDate={BirthDate}, BaseSalary={BaseSalary}, DepartamentId={DeptId}",
                            seller.Name, seller.Email, seller.BirthDate, seller.BaseSalary, seller.DepartamentId);

                        await _sellerService.InsertAsync(seller);

                        _logger.LogInformation("Insert completed for seller with Id={Id}", seller.Id);

                        return RedirectToAction(nameof(Index));
                    }

                    public async Task<IActionResult> Delete(int? id)
                    {
                        if (id == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not provided" });
                        }

                        var obj = await _sellerService.FindByIdAsync(id.Value);
                        if (obj == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not found" });
                        }

                        return View(obj);
                    }

                    [HttpPost]
                    [ValidateAntiForgeryToken]
                    public async Task<IActionResult> Delete(int id)
                    {
                        await _sellerService.RemoveAsync(id);
                        return RedirectToAction(nameof(Index));
                    }

                    public async Task<IActionResult> Details(int? id)
                    {
                        if (id == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not provided" });
                        }

                        var obj = await _sellerService.FindByIdAsync(id.Value);
                        if (obj == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not found" });
                        }

                        return View(obj);
                    }

                    public async Task<IActionResult> Edit(int? id)
                    {
                        if (id == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not provided" });
                        }

                        var obj = await _sellerService.FindByIdAsync(id.Value);
                        if (obj == null)
                        {
                            return RedirectToAction(nameof(Error), new { message = "Id not found" });
                        }

                        List<Departament> departaments = await _departamentService.FindAllAsync();
                        SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departaments = departaments };
                        return View(viewModel);
                    }

                    [HttpPost]
                    [ValidateAntiForgeryToken]
                    public async Task<IActionResult> Edit(SellerFormViewModel viewModel)
                    {
                        if (!ModelState.IsValid)
                        {
                            viewModel.Departaments = await _departamentService.FindAllAsync();
                            return View(viewModel);
                        }

                        try
                        {
                            await _sellerService.UpdateAsync(viewModel.Seller);
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

                    public IActionResult Error(string message)
                    {
                        var viewModel = new ErrorViewModel
                        {
                            Message = message,
                            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                        };
                        return View(viewModel);
                    }
                }
            }
