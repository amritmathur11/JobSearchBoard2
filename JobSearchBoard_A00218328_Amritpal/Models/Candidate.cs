using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;

namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Candidate : KeyAutoIncrement
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(100)]
        public string LastName { get; set;}

        [StringLength(100)]
       
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        public int Age { get; set; }
        [StringLength(100)]

        public string Address { get; set; }

        
    }
}
