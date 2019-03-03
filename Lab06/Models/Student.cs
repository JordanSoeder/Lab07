using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Lab06.Models
{
    public class Student
    {
        public virtual int StudentID { get; set; }

        [Required(ErrorMessage = "Your First Name is required.")]
        [StringLength(50, ErrorMessage ="Your First Name is too long.")]
        public virtual string FirstName { get; set; }

        [Required(ErrorMessage = "Your Last Name is required.")]
        [StringLength(50, ErrorMessage = "Your Last Name is too long.")]
        public virtual string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Address2 cannot be the same as Address1")]
        
        public string Address2 { get; set; }

        public string City { get; set; }

        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Enter a 5 digit Zip code")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "State is Required")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Enter a 2 digit State code")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Enter a 2 digit State code")]
        public string State { get; set; }






    }
}