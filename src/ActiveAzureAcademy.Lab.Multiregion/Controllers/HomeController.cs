using System;
using ActiveAzureAcademy.Lab.Multiregion.Configuration;
using ActiveAzureAcademy.Lab.Multiregion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ActiveAzureAcademy.Lab.Multiregion.Controllers
{
    public class HomeController : Controller
    {
        private readonly RegionConfiguration _regionConfiguration;

        public HomeController(IOptions<RegionConfiguration> regionConfiguration)
        {
            _regionConfiguration = regionConfiguration.Value;
        }

        public ActionResult Index()
        {
            return View(new HomeViewModel()
            {
                Location = _regionConfiguration.RegionName,
                LocalTime = DateTime.Now
            });
        }
    }
}
