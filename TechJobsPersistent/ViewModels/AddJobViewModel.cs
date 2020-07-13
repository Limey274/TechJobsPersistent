using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Please Enter a job name")]
        public string JobName { get; set; }

        [Required(ErrorMessage = "Please enter a Location")]
        public int EmployerId { get; set; }

        public List<SelectListItem> AllEmployers { get; set; }

        public AddJobViewModel(List<Employer> employers)
        {
            AllEmployers = new List<SelectListItem>();
            foreach (Employer emp in employers)
            {
                AllEmployers.Add(new SelectListItem
                {

                    Text = emp.Name,
                    Value = emp.Id.ToString()

                });
            }
        }

        public AddJobViewModel()
        {


        }

    }
}

