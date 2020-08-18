using RepositoryPattern.Repository;
using SampleDotNetWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Tests.Repositories
{
    public class MoqStudentRepository : IStudentRepository
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public Task<Student> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Student>> GetStudentsAsync()
        {
            return await Task.FromResult(Students);
        }
    }
}
