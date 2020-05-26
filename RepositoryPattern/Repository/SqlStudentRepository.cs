using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestingTut.Models;

namespace RepositoryPattern.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        public Task<Student> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
