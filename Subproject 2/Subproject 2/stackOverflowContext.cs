using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Subproject_2
{
    class stackOverflowContext : DbContext 
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(
                "Server = localhost; Port = 3306; Database = mydb; Uid = root; Pwd = roedbeder;" //put your own UserID and Password here
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Marking>()
                .HasKey(o => new { o.userID, o.postId });
        }
    }
}
