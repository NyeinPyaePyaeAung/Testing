using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vindly.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public double PM { get; set; }

        public double RD { get; set; }

        public double UT { get; set; }

        public double OT { get; set; }

       

       
    }
}
