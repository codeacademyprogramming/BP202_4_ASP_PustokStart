using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _context.Portfolios.Include(x => x.Category).Include(x => x.PortfolioImages).ToList(),
                Categories = _context.Categories.ToList()
            };

            return View(portfolioVM);
        }

        public IActionResult Detail(int id)
        {
            Portfolio portfolio =  _context.Portfolios
                .Include(x=>x.Category)
                .Include(x=>x.PortfolioImages)
                .FirstOrDefault(x => x.Id == id);

            

            return View(portfolio);
        }
    }
}
