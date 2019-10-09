using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Controllers;
using RepositoryPattern.Controllers.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.RepositoryLayer
{
    public class StudentRepository : IRepository
    {
        private readonly StudentRepoContext _context;

        public StudentRepository(StudentRepoContext context)
        {
            _context = context;
        }

        public void CreateStudents(Student _student)
        {
            _context.student.Add(_student);
        }

         public IEnumerable<Student> GetAllStudents()
        {
            return _context.student;
           
         }

        
    }
}
