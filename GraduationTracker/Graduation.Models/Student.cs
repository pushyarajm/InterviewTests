// <copyright file="Student.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    using Graduation.Utilities;

    /// <summary>
    /// Student Model
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets Id field
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Courses
        /// </summary>
        public Course[] Courses { get; set; }

        /// <summary>
        /// Gets or sets Standing
        /// </summary>
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
