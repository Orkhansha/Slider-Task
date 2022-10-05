using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SliderText> sliderTexts = _context.SliderTexts.ToList();
            SliderImage sliderImage = _context.SliderImages.FirstOrDefault();
            List<RecentWork> recentWorks = _context.RecentWorks.ToList();
            List<RecentWorkSecond> recentWorkSeconds = _context.RecentWorkSeconds.ToList();
            HomeVM model = new HomeVM
            {
                SliderImage = sliderImage,
                SliderTexts = sliderTexts,
                RecentWorks = recentWorks,
                RecentWorkSeconds = recentWorkSeconds,
            };

            return View(model);
        }
    }
}
