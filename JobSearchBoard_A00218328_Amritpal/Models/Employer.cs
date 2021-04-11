using JobSearchBoard_A00218328_Amritpal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;

namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Employer : KeyAutoIncrement
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Year Established")]
        public DateTime YearEstablished { get; set; }
        [StringLength(1000)]
        public string Biography { get; set; }

       
    }
}
