// <copyright file="Diploma.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.Models
{
    /// <summary>
    /// Diploma Model
    /// </summary>
    public class Diploma
    {
        /// <summary>
        /// Gets or sets Id field
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Credits field
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets Requirements field
        /// </summary>
        public int[] Requirements { get; set; }
    }
}
