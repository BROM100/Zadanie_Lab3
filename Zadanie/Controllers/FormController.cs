using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.Models;

namespace Zadanie.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ilosc_powtorzen >= 1 && model.ilosc_powtorzen <= 5)
                {
                    model.belongs = "Należy";
                    return View("Answer", model);
                }
                else
                {
                    model.belongs = "Nie należy";
                    return View("Answer", model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}