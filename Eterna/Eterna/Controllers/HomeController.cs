using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.OrderBy(x=>x.Order).ToList();

            List<Feature> features = new List<Feature>
            {
                new Feature
                {
                    Id = 1,
                    Title = "BP202 Programming",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-card-checklist\"></i>"
                },
                new Feature
                {
                    Id = 2,
                    Title = "BD202 Design",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-bar-chart\"></i>"
                },
                 new Feature
                 {
                    Id = 7,
                    Title = "BD202 System",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-binoculars\"></i>"
                 }
            };

            List<Service> services = _context.Services.ToList();

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Features = features,
                Services = services
            };

            return View(homeVM);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
