using Microsoft.EntityFrameworkCore;
using MyCourses.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

ServerVersion serverVersion = new MariaDbServerVersion(new Version(10, 5, 12));

builder.Services.AddDbContext<MyCoursesDbContext>(options =>
 options.UseMySql(builder.Configuration.GetConnectionString("MyCoursesDb"), serverVersion)
 .LogTo(Console.WriteLine, LogLevel.Information)
 .EnableSensitiveDataLogging()
 .EnableDetailedErrors()
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
