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
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Tags)
                .WithMany(p => p.Products)
                .UsingEntity<ProductTag>(
                    j => j
                        .HasOne(pt => pt.Tag)
                        .WithMany(t => t.ProductTags)
                        .HasForeignKey(pt => pt.TagId),
                    j => j
                        .HasOne(pt => pt.Product)
                        .WithMany(p => p.ProductTags)
                        .HasForeignKey(pt => pt.ProductId),
                    j =>
                    {
                        //j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
                        j.HasKey(t => new { t.ProductId, t.TagId });
                    });
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Options);
            modelBuilder.Entity<Option>()
                .HasMany(o => o.OptionValues);
        }
    }
}
