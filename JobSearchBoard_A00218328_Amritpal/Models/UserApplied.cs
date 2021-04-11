using JobSearchBoard_A00218328_Amritpal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class UserApplied : KeyAutoIncrement
    {
        public int ID { get; set; }

        public string UserName { get; set; }


        public int? UserID { get; set; }
        public string Description { get; set; }


    }
}
