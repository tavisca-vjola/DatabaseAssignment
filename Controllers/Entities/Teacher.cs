using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers.Models
{
    public class Teacher
    {
        [Key]
        public int Tid { get; set; }
        public string Tname { get; set; }
        public int Tage { get; set; }
        public List<Student> _students { set; get; }

    }
}
