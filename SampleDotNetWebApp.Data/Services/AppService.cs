using RepositoryPattern.Repository;
using SampleDotNetWebApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * @mrjamiebowman
 * 
 * Facade
 * The AppService will act as a facade to wrap individual repositories. Typically, I break this apart even further 
 * and move the service layer code (service, repositories) into their own dynamic library. That way it can be re-usable.
 * This is also a good idea because if hypothetically I wanted to change out this MVC architecture for a SPA app
 * all I would have to do is add a new project and include a reference to that dynamic library.
 * 
 * Best Practices
 * I also believe that the repository code should only write to the data source. If the idea is to write repository
 * code that can be swapped out we shouldn't be applying any logic in the repository it should happen in the service.
 * Putting that code in the controller also means that it won't be distributable in a dynamic library.
 * 
 * Dependency Injection
 * The dependency resolver will inject the concrete class that is being mapped to IStudentRepository during 
 * app start up.
 */

namespace SampleDotNetWWebApp.Services
{
    public class AppService : IAppService
    {
        protected readonly IStudentRepository _StudentRepo;

        public AppService(IStudentRepository studentRepo)
        {
            _StudentRepo = studentRepo;
        }

        public Task<Student> GetStudentByIdAsync(int id)
        {
            return _StudentRepo.GetStudentByIdAsync(id);
        }

        public Task<IList<Student>> GetStudentsAsync()
        {
            return _StudentRepo.GetStudentsAsync();
        }

        public Task CelebrateBirthdayAsync(int id)
        {
            // TODO: get student

            // TODO: send birthday email to teacher

            // TODO: send birthday email to student

            // TODO: mark as sent

            throw new System.NotImplementedException();
        }
    }
}
