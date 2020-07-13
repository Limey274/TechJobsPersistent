using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Please Enter a Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Please Enter a Location")]
        public string Location { get; set; }
        
        
        
        public AddEmployerViewModel()
        {
           
        }
    }
}
