namespace WebApplication2.Models;

using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

public class InfoContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}