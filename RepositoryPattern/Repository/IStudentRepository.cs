using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingTut.Models;

namespace RepositoryPattern.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(int id);
    }
}
