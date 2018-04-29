using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using PMS.Data;
using Microsoft.EntityFrameworkCore;
using PMS.Models;
using PMS.ViewModels;

namespace PMS.Controllers
{
    public class TaskController : Controller
    {
        private readonly PMSDbContext context;

        public TaskController(PMSDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Task> tasks = context.Tasks.ToList();

            //IList<Task> tasks = context.Tasks.Include(c => c.Project).ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddTaskViewModel addTaskViewModel = new AddTaskViewModel();
            return View(addTaskViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddTaskViewModel addTaskViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new task to my existing tasks
                Task newTask = new Task
                {
                    Name = addTaskViewModel.Name,
                    Description = addTaskViewModel.Description,
                    ProjectID = addTaskViewModel.ProjectID
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();

                return Redirect("/Task");
            };

            return View(addTaskViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.title = "Delete Tasks";
            ViewBag.Tasks = context.Tasks.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] taskIds)
        {
            foreach (int taskId in taskIds)
            {
                Task theTask = context.Tasks.Single(c => c.ID == taskId);
                context.Tasks.Remove(theTask);
            }

            context.SaveChanges();

            return Redirect("/Task");
        }
    }
}