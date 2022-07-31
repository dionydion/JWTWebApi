using System;
using Microsoft.EntityFrameworkCore;
using JWTWebApiTutorial.Models;
namespace JWTWebApiTutorial.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<User> users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}

