﻿// <copyright file="GraduationTracker.cs" company="Xello">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Graduation.BAL
{
    using System;
    using Graduation.Models;
    using Graduation.Repository;
    using Graduation.Utilities;

    /// <summary>
    /// Business logic to track graduation logic.
    /// </summary>
    public class GraduationTracker
    {
        /// <summary>
        /// Business Logic to determine if the students has graduated
        /// </summary>
        /// <param name="student">Student info</param>
        /// <param name="diploma">Diploma info</param>
        /// <returns name = "Tuple(bool,STANDING)">Graduated or not</returns>
        public Tuple<bool, STANDING> HasGraduated(Student student, Diploma diploma)
        {
            try
            {
                var average = this.CalculateAverage(student, diploma);

                var hasGraduated = this.ProcessAverage(average);

                return hasGraduated;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busines Logic to derieve average
        /// </summary>
        /// <param name="student">Student info</param>
        /// <param name="diploma">Diploma info</param>
        /// /// <returns>average</returns>
        private int CalculateAverage(Student student, Diploma diploma)
        {
            try
            {
                var credits = 0;
                var average = 0;

                foreach (var d in diploma.Requirements)
                {
                    foreach (var s in student.Courses)
                    {
                        var requirement = Repository.GetRequirement(d);

                        foreach (var req in requirement.Courses)
                        {
                            if (req == s.Id)
                            {
                                average += s.Mark;
                                if (s.Mark > requirement.MinimumMark)
                                {
                                    credits += requirement.Credits;
                                }
                            }
                        }
                    }
                }

                return average / student.Courses.Length;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Process Average and derieve Standing
        /// </summary>
        /// <param name="average">average</param>
        /// <returns>hasGraduated</returns>
        private Tuple<bool, STANDING> ProcessAverage(int average)
        {
            var standing = this.GetStanding(average);

            switch (standing)
            {
                case STANDING.Remedial:
                    return new Tuple<bool, STANDING>(false, standing);
                case STANDING.Average:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.SumaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.MagnaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);
                default:
                    return new Tuple<bool, STANDING>(false, standing);
            }
        }

        /// <summary>
        ///  Function to get Standing based on average.
        /// </summary>
        /// <param name="average">int value</param>
        /// <returns>Standinh enum</returns>
        private STANDING GetStanding(int average)
        {
            if (average < 50)
            {
                return STANDING.Remedial;
            }
            else if (average < 80)
            {
                return STANDING.Average;
            }
            else if (average < 95)
            {
                return STANDING.MagnaCumLaude;
            }
            else if (average <= 100)
            {
                return STANDING.MagnaCumLaude;
            }
            else
            {
                return STANDING.None;
            }
        }
    }
}
