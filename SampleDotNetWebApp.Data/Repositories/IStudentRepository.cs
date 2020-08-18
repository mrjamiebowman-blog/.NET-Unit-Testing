using SampleDotNetWebApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleDotNetWWebApp.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(int id);
        Task<IList<Student>> GetStudentsAsync();
    }
}
