using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    public class AddTaskViewModel
    {
        
        

            [Required]
            [Display(Name = "Task Name")]
            public string Name { get; set; }

            [Required(ErrorMessage = "You must give your task a description")]
            public string Description { get; set; }

            [Required]
            [Display(Name = "project")]
            public int ProjectID { get; set; }

            public int ID { get; set; }


            public AddTaskViewModel()
            {
            }
        
    }
}
