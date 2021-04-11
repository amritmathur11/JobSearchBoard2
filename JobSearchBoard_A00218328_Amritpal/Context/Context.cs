using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobSearchBoard_A00218328_Amritpal.Models;

namespace JobSearchBoard_A00218328_Amritpal.Contexts
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Employer> Employe { get; set; }
        public DbSet<Job_Application> JobApplication { get; set; }
        public DbSet<Job_Posting> JobPosting { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<Saved_Search> SavedSearch { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<JobDescription> JobDescription { get; set; }
        public DbSet<JobSearchBoard_A00218328_Amritpal.Models.UserApplied> UserApplied { get; set; }

    }
}
