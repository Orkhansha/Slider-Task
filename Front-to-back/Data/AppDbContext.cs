using Front_to_back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<SliderText> SliderTexts { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<RecentWorkSecond> RecentWorkSeconds { get; set; }
    }
}
