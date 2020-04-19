using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AllCore.Models;
using AllCore.DLServiceInterfaces;
using AllCore.BLServiceIntefaces;

namespace AllCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDemo _demoService;
        private readonly IBLDemos _blDemoService;

        public HomeController(ILogger<HomeController> logger, IDemo demo, IBLDemos bLDemos)
        {
            _logger = logger;
            _demoService = demo;
            _blDemoService = bLDemos;
        }

        public IActionResult Index()
        {
            try
            {
                // Controller ==>> DL
                // accessing directly as DL
                string x = _demoService.GetDataFromDL();
                _logger.LogInformation(x);
                _logger.LogDebug("Index132", "Test Message");
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Privacy()
        {
            // Controller ==>> BL ==>> DL
            string x = _blDemoService.GetDataFromBL();
            _logger.LogInformation(x);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
