using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mental_Capacity_Assessments.Models
{
    public class Questions
    {
        public string Description { get; set; }
        public string id { get; set; }
        public string yes_button { get; set; }
        public string no_button { get; set; }
        public string yes_next { get; set; }
        public string no_next { get; set; }
    }
}