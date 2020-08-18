using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern.Tests.Repositories;
using SampleDotNetWebApp.Domain.Models;
using SampleDotNetWWebApp.Repositories;
using SampleDotNetWWebApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public async Task GetAllStudentsTest()
        {
            // arrange
            IStudentRepository studentRepo = new MoqStudentRepository();

            List<Student> testdata = new List<Student>();

            var student1 = new Student()
            {
                FirstName = "Jamie",
                LastName =  "Bowman",
                Twitter = "mrjamiebowman"
            };
            testdata.Add(student1);

            var student2= new Student()
            {
                FirstName = "Larissa",
                LastName = "Broughton",
            };
            testdata.Add(student2);

            var student3 = new Student()
            {
                FirstName = "Regina",
                LastName = "Ware",
            };
            testdata.Add(student3);

            /*
             * This is only for conceptional purposes. Try and focus on how this
             * works. This is not best practice. There are better ways of faking
             * the data that is being returned. I'll go over Moq in a later project.
             */
            ((MoqStudentRepository)studentRepo).Students = testdata;

            var appService = new AppService(studentRepo);

            // act
            List<Student> students = (List<Student>)await appService.GetStudentsAsync();

            // assert
            //Assert.AreEqual<int>(1, students.Count, "This should fail as expected. Try it out.");
            Assert.AreEqual<int>(3, students.Count, "There should have been 3 students returned.");
        }
    }
}
