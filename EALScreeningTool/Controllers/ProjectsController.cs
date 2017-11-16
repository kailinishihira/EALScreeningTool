using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EALScreeningTool.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace EALScreeningTool.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            if(_db.Projects.Count() == 0)
            {
                return RedirectToAction("Create");
            } else
            {
                var projectList = _db.Projects.OrderBy((x => x.ProjectName)).ToList();
                return View(projectList);
            }            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var currentUser = await _userManager.FindByIdAsync(userId);
                project.User = currentUser;
                _db.Projects.Add(project);
                _db.SaveChanges();
                return RedirectToAction("Details", new { projectId = project.ProjectId });
            } else
            {
                return View("Error", "Shared");
            }
            
        }

        public IActionResult Details(int projectId)
        {
            var thisProject = _db.Projects.Include(project => project.User)
                .FirstOrDefault(project => project.ProjectId == projectId);
            return View(thisProject);
        }

        public IActionResult Edit(int projectId)
        {
            var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == projectId);
            return View(thisProject);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            _db.Entry(project).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", new { projectId = project.ProjectId });
        }

        public IActionResult Delete(int projectId)
        {
            var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == projectId);
            return View(thisProject);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int projectId)
        {
            var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == projectId);
            _db.Projects.Remove(thisProject);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
