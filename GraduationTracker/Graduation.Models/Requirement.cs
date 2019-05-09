// <copyright file="Requirement.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    /// <summary>
    /// Requirement Model
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Gets or sets Id Field
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Name Field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MinimumMark Field
        /// </summary>
        public int MinimumMark { get; set; }

        /// <summary>
        /// Gets or sets Credits Field
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets Courses
        /// </summary>
        public int[] Courses { get; set; }
    }
}
