using RepositoryPattern.Controllers.Models;
using System.Collections.Generic;

namespace RepositoryPattern.RepositoryLayer
{
    public interface IRepository
    {
         IEnumerable<Student> GetAllStudents();
         void CreateStudents(Student _element);
    }
}