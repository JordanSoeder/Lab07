using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Lab06.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentID { get; set; }
        public virtual int StudentID { get; set; }
        public virtual int CourseID { get; set; }

        [Required(ErrorMessage = "Grade is required.")]
        [RegularExpression(@"[A-Za-z0-9._%+-] + @[A-za-z0-9.-] +\.[A-Za -z]{2,4}")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual bool isActive { get; set; }

        [Required(ErrorMessage = "Campus is required.")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "Semester is required.")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "Enrolllment Year is required.")]
        [Range(typeof(int), "2018", "2999")]
        public virtual int EnrollmentYear { get; set; }
    }
}