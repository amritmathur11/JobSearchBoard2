using JobSearchBoard_A00218328_Amritpal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Resume : KeyAutoIncrement
    {
        public int ID { get; set; }
        
        public string Candiate { get; set; }

        public string Experience { get; set; }
        [StringLength(1000)]

        public string Skills { get; set; }
    }
}
