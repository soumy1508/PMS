using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Project Project { get; set; }
        public int ProjectID { get; set; }
    }
}
