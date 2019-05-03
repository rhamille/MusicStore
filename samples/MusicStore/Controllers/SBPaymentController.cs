using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    [Authorize]
    public class SBPaymentController : Controller
    {
        private const string PromoCode = "FREE";

        private readonly ILogger<CheckoutController> _logger;

        public SBPaymentController(ILogger<CheckoutController> logger)
        {
            _logger = logger;
        }

        //
        // GET: /Checkout/
        public IActionResult AddressAndPayment()
        {
            return View();
        }
        
    }
}