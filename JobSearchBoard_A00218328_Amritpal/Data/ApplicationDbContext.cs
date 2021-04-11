using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JobSearchBoard_A00218328_Amritpal.Models;

namespace JobSearchBoard_A00218328_Amritpal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Candidate> Candidate { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Employer> Employer { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Job_Application> Job_Application { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Job_Posting> Job_Posting { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Notification> Notification { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Resume> Resume { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.Saved_Search> Saved_Search { get; set; }
    }
}
