using CreditCardApplication.Models;
using CreditCardApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardApplication.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationRepository _appRepository;
        private readonly ICardRepository _cardRepository;
        private readonly ICreditCardCalculatorService _calculatorService;

        public ApplicationController(IApplicationRepository appRepository, ICardRepository cardRepository, ICreditCardCalculatorService calculatorService)
        {
            _appRepository = appRepository;
            _cardRepository = cardRepository;
            _calculatorService = calculatorService;
        }
        public IActionResult List()
        {
            return View(_appRepository.AllApplications);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Application app)
        {
            if (ModelState.IsValid)
            {
                app.ApplicationCardResult = _calculatorService.CalculateCardType(app);
                _appRepository.SaveApplication(app);
                return RedirectToAction("ApplicationComplete", app.ApplicationCardResult);
            }
            return View(app);

        }

        public IActionResult ApplicationComplete(Card c)
        {
            return View(c);
        }
    }
}
