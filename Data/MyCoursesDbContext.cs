using Microsoft.EntityFrameworkCore;
using MyCourses.Models;

namespace MyCourses.Data;

public class MyCoursesDbContext : DbContext{
    public MyCoursesDbContext(DbContextOptions<MyCoursesDbContext> options)
        : base(options) { }

    // EF Core will use these to perform CRUD operations on the database tables for you on the .
    public virtual DbSet<Course>? Courses { get; set; }
    public virtual DbSet<Assignment>? Assignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        // here we've overridden the method so that we can choose the name of our tables
        // since database tables are supposed to be singular, we name that way here
        // otherwise they'd be plural (e.g. Courses) in the database.
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Assignment>().ToTable("Assignment");
    }
}

