using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graduation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation.Repository.Tests
{
    /// <summary>
    /// Test class with methods for Repository class
    /// </summary>
    [TestClass]
    public class RepositoryTests
    {
        /// <summary>
        /// Test for successfull fetching of student
        /// </summary>
        [TestMethod]
        public void GetStudentTest()
        {
            var student = Repository.GetStudent(1);

            Assert.AreEqual(student.Courses[0].Mark, 95);
        }

        /// <summary>
        /// Test for no student being abe to be fetched
        /// </summary>
        [TestMethod]
        public void GetStudent_FailureTest()
        {
            var student = Repository.GetStudent(100);

            Assert.AreEqual(student, null);
        }

        /// <summary>
        /// Test for fetching the diploma details
        /// </summary>
        [TestMethod()]
        public void GetDiplomaTest()
        {
            var diploma = Repository.GetDiploma(1);

            Assert.AreEqual(diploma.Credits, 4);
        }

        /// <summary>
        /// Test for no diploma details being fetched in the process
        /// </summary>
        [TestMethod()]
        public void GetDiploma_failureTest()
        {
            var diploma = Repository.GetDiploma(100);

            Assert.AreEqual(diploma, null);
        }

        /// <summary>
        /// Test for requirement details being fetched
        /// </summary>
        [TestMethod()]
        public void GetRequirementTest()
        {
            var requirement = Repository.GetRequirement(100);

            Assert.AreEqual(requirement.Name, "Math");
        }
        
        /// <summary>
        /// Test for no requirement details being fetched in the process
        /// </summary>
        [TestMethod()]
        public void GetRequirement_failureTest()
        {
            var requirement = Repository.GetRequirement(1);

            Assert.AreEqual(requirement, null);
        }
    }
}