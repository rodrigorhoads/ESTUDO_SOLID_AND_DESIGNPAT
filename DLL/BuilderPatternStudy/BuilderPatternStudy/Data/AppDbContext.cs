using BuilderPatternStudy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BuilderPatternStudy.Data
{
    public class AppDbContext : DbContext
    {
       public DbSet<ComputerParts> Parts { get; set; }       

    }
}