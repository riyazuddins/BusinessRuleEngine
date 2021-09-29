using BusinessRuleEngine.Models;
using BusinessRuleEngine.Service.Interface;
using BusinessRuleEngine.Service.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPaymentService _payment;
        public HomeController(ILogger<HomeController> logger, IPaymentService payment)
        {
            _logger = logger;
            _payment = payment;
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
        public ActionResult ProcessPayment(Payment paymentModel)
        {
            var result =  _payment.ProcessOrder(paymentModel.Product.ToString());
            SuccessModel successModel = new SuccessModel();
            successModel.Message = result;
            return View("Success", successModel);
        }
    }
}
