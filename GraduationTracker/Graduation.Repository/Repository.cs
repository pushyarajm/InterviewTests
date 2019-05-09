// <copyright file="Repository.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

// Pushyaraj - Updated to lambda expressions to simplify the code logic
namespace Graduation.Repository
{
    using System.Collections;
    using System.Linq;
    using Graduation.Models;

    /// <summary>
    /// Class holding repository and supprted functions.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Reterive specific Student info from diploma repo
        /// </summary>
        /// <param name="id">identity key</param>
        /// <returns>Student Model</returns>
        public static Student GetStudent(int id)
        {
            var students = GetStudents();

            var student = students.Where(x => x.Id == id);

            // If no student returned return null
            var rtn = (student.Count() == 0) ? null : student.ToList()[0];
            return rtn;
        }

        /// <summary>
        /// Reterive specific Diploma info from diploma repo
        /// </summary>
        /// <param name="id">Identify</param>
        /// <returns>Diploma Model</returns>
        public static Diploma GetDiploma(int id)
        {
            var diplomas = GetDiplomas();

            var diploma = diplomas.Where(x => x.Id == id);

            // If no diploma details returned return null
            var rtn = (diploma.Count() == 0) ? null : diploma.ToList()[0];
            return rtn;
        }

        /// <summary>
        /// Reterive specific Requirement info from requirement repo
        /// </summary>
        /// <param name="id">Identify</param>
        /// <returns>Requirement Model</returns>
        public static Requirement GetRequirement(int id)
        {
            var requirements = GetRequirements();
            var requirement = requirements.Where(x => x.Id == id);

            // If no requirement details returned return null
            var rtn = (requirement.Count() == 0) ? null : requirement.ToList()[0];
            return rtn;
        }

        /// <summary>
        /// Reterive specific Requirement info from requirement repo
        /// </summary>
        /// <returns>Requirement Model</returns>
        private static Diploma[] GetDiplomas()
        {
            return new[]
            {
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = new int[] { 100, 102, 103, 104 }
                }
            };
        }

        /// <summary>
        /// Get All Requirements from database
        /// </summary>
        /// <returns>Requirement list</returns>
        private static Requirement[] GetRequirements()
        {
                return new[]
                {
                    new Requirement { Id = 100, Name = "Math", MinimumMark = 50, Courses = new int[] { 1 }, Credits = 1 },
                    new Requirement { Id = 102, Name = "Science", MinimumMark = 50, Courses = new int[] { 2 }, Credits = 1 },
                    new Requirement { Id = 103, Name = "Literature", MinimumMark = 50, Courses = new int[] { 3 }, Credits = 1 },
                    new Requirement { Id = 104, Name = "Physichal Education", MinimumMark = 50, Courses = new int[] { 4 }, Credits = 1 }
                };
        }

        /// <summary>
        /// Get All Student info from database
        /// </summary>
        /// <returns>Student list</returns>
        private static Student[] GetStudents()
        {
            return new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new Course[]
                   {
                        new Course { Id = 1, Name = "Math", Mark = 95 },
                        new Course { Id = 2, Name = "Science", Mark = 95 },
                        new Course { Id = 3, Name = "Literature", Mark = 95 },
                        new Course { Id = 4, Name = "Physichal Education", Mark = 95 }
                   }
               },
               new Student
               {
                   Id = 2,
                   Courses = new Course[]
                   {
                        new Course { Id = 1, Name = "Math", Mark = 80 },
                        new Course { Id = 2, Name = "Science", Mark = 80 },
                        new Course { Id = 3, Name = "Literature", Mark = 80 },
                        new Course { Id = 4, Name = "Physichal Education", Mark = 80 }
                   }
               },
            new Student
            {
                Id = 3,
                Courses = new Course[]
                {
                    new Course { Id = 1, Name = "Math", Mark = 50 },
                    new Course { Id = 2, Name = "Science", Mark = 50 },
                    new Course { Id = 3, Name = "Literature", Mark = 50 },
                    new Course { Id = 4, Name = "Physichal Education", Mark = 50 }
                }
            },
            new Student
            {
                Id = 4,
                Courses = new Course[]
                {
                    new Course { Id = 1, Name = "Math", Mark = 40 },
                    new Course { Id = 2, Name = "Science", Mark = 40 },
                    new Course { Id = 3, Name = "Literature", Mark = 40 },
                    new Course { Id = 4, Name = "Physichal Education", Mark = 40 }
                }
            }
            };
        }
    }
}
