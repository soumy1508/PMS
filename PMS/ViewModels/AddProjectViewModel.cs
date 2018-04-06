using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class AddProjectViewModel
    {
        [Required]
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your project a description")]
        public string Description { get; set; }

        public int ID { get; set; }
    }
}
