using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTestingTut.Models;

/*
 * @mrjamiebowman
 *
 * This code will execute when the UI is ran.
 *
 * It will be mapped into the service class through
 * dependency injection. This code will read from a
 * real Sqlite database
 */

namespace RepositoryPattern.Repository
{
    public class SqliteStudentRepository : IStudentRepository
    {
        public Task<Student> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Student>> GetStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
