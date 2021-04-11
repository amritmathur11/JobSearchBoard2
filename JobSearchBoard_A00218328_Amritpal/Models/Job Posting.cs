using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;


namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Job_Posting : KeyAutoIncrement
    {
         public int ID { get; set; }
        [Display(Name = "Job Title")]
        public string Company { get; set; }
        
        [Display(Name = "Description")]
        [StringLength(1000)]
        public string Description { get; set; }
        
        public int Salary { get; set; }

    }

     
    
}
