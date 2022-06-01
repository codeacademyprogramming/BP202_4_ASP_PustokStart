using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        private AppDbContext _context;
        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            ServiceViewModel serviceVM = new ServiceViewModel
            {
                Services = services
            };

            return View(serviceVM);
        }

        public IActionResult Detail(int id)
        {
            Service service = _context.Services.FirstOrDefault(x => x.Id == id);

            return View(service);
        }
    }
}
