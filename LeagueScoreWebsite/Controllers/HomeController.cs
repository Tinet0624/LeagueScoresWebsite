using IdentityLogin.Models;
using LeagueScoreWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeagueScoreWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailProvider _emailProvider;

        public HomeController(ILogger<HomeController> logger, IEmailProvider emailProvider)
        {
            _logger = logger;
            _emailProvider = emailProvider; // this was added to enable email to be sent
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

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(ContactUsModel contactUsModel)
        {
            if (ModelState.IsValid) { 
                await _emailProvider.SendEmailAsync(contactUsModel.toEmail, null, contactUsModel.subject, contactUsModel.content, contactUsModel.name);
            } 
            return View();
        }
    }
}