using SampleDotNetWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * @mrjamiebowman
 * 
 * I'm only going to put this code here for demonstrational purposes.
 * There will be a Sqlite database (SqliteStudentRepository.cs) that 
 * is connected to using EF Core. However, this code is to demonstrate 
 * using ADO.NET to connect to a remote MSSQL server. There actually 
 * won't be a remote database that this could connect to. This is just
 * for demonstrational purposes. But, the general idea of the 
 * repository pattern is that you should be able to change out your 
 * data source/destination by updating the maps to the 
 * dependency resolver.
 *
 */

namespace SampleDotNetWWebApp.Repositories
{
    public class SqlStudentRepository : IStudentRepository
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
