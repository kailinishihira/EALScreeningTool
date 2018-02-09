using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EALScreeningTool.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EALScreeningTool.Controllers
{
    [Authorize]
    public class SamplesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public SamplesController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
                        
            public IActionResult Index()
        {
            return View();
        }
    }
}
