using System.ComponentModel.DataAnnotations;
using Adventum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Adventum.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;


namespace Adventum.Controllers
{
    public class SportsController : Controller
    {

       

        private readonly AdventureContext _context;

        public SportsController(AdventureContext context)
        {
            
            _context = context;
        }
        public IActionResult ATVpage()
        {
            return View();
        }
        public IActionResult BalloonPage()
        {
            return View();
        }
        public IActionResult BungeePage()
        {
            return View();
        }
        public IActionResult ClimbPage()
        {
            return View();
        }
        public IActionResult ParaPage()
        {
            return View();
        }
        public IActionResult RaftingPage()
        {
            return View();
        }
        public IActionResult SkydivePage()
        {
            return View();
        }
        public IActionResult SnowPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
