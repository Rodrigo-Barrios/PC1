using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PC1.Controllers
{
    [Route("[controller]")]
    public class OpereEnBolsaController : Controller
    {
        private readonly ILogger<OpereEnBolsaController> _logger;

        public OpereEnBolsaController(ILogger<OpereEnBolsaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}