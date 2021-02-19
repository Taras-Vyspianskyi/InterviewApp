using InterviewApp.Common.Entity;
using InterviewApp.DataAccess.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constructors        

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public ApplicationContext()
        {
        }

        #endregion

        public DbSet<User> People { get; set; }
        public DbSet<Group> Group { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new GroupConfig());
        }
    }
}
