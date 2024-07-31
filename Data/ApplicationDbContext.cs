﻿using System;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
namespace StudentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public
        ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options)
        : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
    }
}

