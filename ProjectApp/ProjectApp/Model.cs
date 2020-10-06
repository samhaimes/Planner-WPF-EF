using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProjectModel;
using System.Collections.Generic;


namespace ProjectModel
{
    public class ProjectContext : DbContext
    {
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Activities> GetActivities { get; set; }
        public DbSet<LinkTable> linkTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }


}
