using Microsoft.EntityFrameworkCore;
using sample_app.Models;

namespace sample_app.Data
{
    public class SampleAppContext : DbContext
    {
        public SampleAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasMany(p => p.Options);
        //    modelBuilder.Entity<Option>().HasMany(o => o.OptionValues);
        //}
    }
}
