using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Models;
using System;

namespace StudentEmployementPortal.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Application> Application { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        
        public DbSet<Referee> Referees { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
