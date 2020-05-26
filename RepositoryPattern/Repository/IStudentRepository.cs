using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTestingTut.Models;

namespace RepositoryPattern.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(int id);
        Task<IList<Student>> GetStudentsAsync();
    }
}
