using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    public class StudentRepoContext:DbContext
    {
        public StudentRepoContext(DbContextOptions<StudentRepoContext>options):base(options)
        {
            Database.Migrate();

        }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> student { get; set; }


    }
}
