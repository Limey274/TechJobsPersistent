using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        // GET: /<controller>/

        private JobDbContext context;
            public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {

            List<Employer> employer = context.Employers.ToList();
                

            return View(employer);
        }     

        public IActionResult Add()
        {            
            AddEmployerViewModel viewModel = new AddEmployerViewModel();
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = viewModel.Name,
                    Location = viewModel.Location

                };
                context.Employers.Add(employer);
                context.SaveChanges();

                return Redirect("/Employer");

            }
            return View("Add", viewModel);


            
        }
        // get: /employer/About/{id}


        public IActionResult About(int id)
        {

           Employer employer = context.Employers.Find(id);



            return View(employer);
        }
    }
}
