using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TechJobsAuthentication.Data;
using TechJobsAuthentication.Models;
using TechJobsAuthentication.ViewModels;

namespace TechJobsAuthentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private JobDbContext context;

        public HomeController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            List<Job> jobs = context.Jobs.ToList();

            return View(jobs);
        }

        [HttpGet("/Add")]
        public IActionResult Add()
        {
            AddJobViewModel addJobViewModel = new AddJobViewModel();

            return View(addJobViewModel);
        }


        public IActionResult ProcessAddJobForm(AddJobViewModel addJobViewModel)
        {
            if (ModelState.IsValid)
            {
                Job newJob = new Job
                {
                    Name = addJobViewModel.Name,
                    Employer = addJobViewModel.Employer,
                    Skill = addJobViewModel.Skill
                };

                context.Jobs.Add(newJob);
                context.SaveChanges();

                return Redirect("Index");
            }

            return View("Add", addJobViewModel);
        }

    }
}
