using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;

namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class JobDescription : KeyAutoIncrement
    {
        public int ID { get; set; }

        public string JobTitle { get; set; }

        public string JobDetails { get; set; }
    }
}
