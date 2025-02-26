﻿using Microsoft.EntityFrameworkCore;
using webApiTestGitCommands.Models;

namespace webApiTestGitCommands.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
