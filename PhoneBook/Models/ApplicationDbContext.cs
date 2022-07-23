using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PhoneBook.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ConnectionString")
        {

        }

        public DbSet<PhoneBook> PhoneBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneBook>().HasKey(p => p.Id);
            modelBuilder.Entity<PhoneBook>().Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }

    }
}