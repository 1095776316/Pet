using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Pet.Admin.Models;
using Pet.Core.Dto.AppSettings;

namespace Pet.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer localizer, IConfiguration configuration)
        {
            _logger = logger;
            _localizer = localizer;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var localizationModel = new LocalizationModel();
            _configuration.GetSection(localizationModel.Localizations).Bind(localizationModel);
            ViewBag.Languages = localizationModel.Languages;
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            ViewBag.CurrentLanuageCode = localizationModel?.Languages.Where(p => p.Code.Equals(cultureInfo.Name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetLanguage(string culture)
        {
            HttpContext.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                });
            return Json("OK");
        }
    }
}
