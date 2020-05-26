using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTestingTut.Models;

/*
 * @mrjamiebowman
 * 
 * The CelebrateBirthdayAsync() method is not part of the repository code. 
 */

namespace RepositoryPattern.Services
{
    public interface IAppService
    {
        #region Students

        Task<Student> GetStudentByIdAsync(int id);

        Task<IList<Student>> GetStudentsAsync();

        Task CelebrateBirthdayAsync(int id);

        #endregion
    }
}
