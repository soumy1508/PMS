using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PMS.Data;
using PMS.Models;
using PMS.ViewModels;

namespace PMS.Controllers
{
    public class ProjectController : Controller
    {
        private PMSDbContext context;

        public ProjectController(PMSDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Project> projects = context.Projects.ToList();

            return View(projects);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddProjectViewModel addProjectViewModel = new AddProjectViewModel();
            return View(addProjectViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddProjectViewModel addProjectViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new project to my existing projects
                Project newProject = new Project
                {
                    Name = addProjectViewModel.Name,
                    Description = addProjectViewModel.Description,
                    Budget = addProjectViewModel.Budget
                    

                };

                context.Projects.Add(newProject);
                context.SaveChanges();

                return Redirect("/Project");
            };

            return View(addProjectViewModel);
        }
    }
}