// <copyright file="Course.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    /// <summary>
    /// Course Model
    /// </summary>
    public class Course
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
        /// Gets or sets Mark Field
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Gets Credits Field
        /// </summary>
        public int Credits { get; }
     }
}
