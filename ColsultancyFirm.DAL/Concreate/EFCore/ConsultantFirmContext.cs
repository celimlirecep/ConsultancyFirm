﻿using ConsultancyFirm.EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class ConsultantFirmContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AuthorHeading> AuthorHeadings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ConsultancyFirmDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorHeading>()
                .HasKey(ah => new { ah.AuthorId, ah.HeadingId });
        }
    }
}
