using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Lab06.Models
{
    public class Course
    {
        public virtual int CourseID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(150, ErrorMessage = "Title is required.")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [Required(ErrorMessage = "Credits are required.")]
        [Range(typeof(int), "0", "4", ErrorMessage = "Credit isn't valid.")]
        public virtual int Credits { get; set; }

    }
}