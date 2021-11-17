using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Zadanie.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

        [HttpPost]
        public IActionResult Answer (FormModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ilosc_powtorzen >= 1 && model.ilosc_powtorzen <= 5)
                {
                    model.belongs = "Należy";
                    return View( model);
                }
                else
                {
                    model.belongs = "Nie należy";
                    return View( model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}