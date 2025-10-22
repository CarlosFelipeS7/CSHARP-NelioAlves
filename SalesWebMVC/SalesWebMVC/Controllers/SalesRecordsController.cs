using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var result = await _salesRecordService.FindByDate(minDate, maxDate);

            ViewData["minDate"] = minDate.HasValue ? minDate.Value.ToString("yyyy-MM-dd") : "";
            ViewData["maxDate"] = maxDate.HasValue ? maxDate.Value.ToString("yyyy-MM-dd") : "";

            return View(result);
        }
        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}
