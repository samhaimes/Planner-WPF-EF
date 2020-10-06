using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Planner;
using System.Collections.Generic;


namespace Model
{
    public class ProjectContext : DbContext
    {
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Activities> GetActivities { get; set; }
        public DbSet<Link> Links { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PlannerDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
 
        }

    }


};