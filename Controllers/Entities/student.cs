
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers.Models
{
    public class Student
    {
        [Key]
        public Int64 Id { get;  set; }

        public string Sname { get; set; }
        public string Sdept { get; set; }
        public string Ssection { get; set; }
        public string Sage { get; set; }
    }
}
