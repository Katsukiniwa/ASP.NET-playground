using Microsoft.EntityFrameworkCore;
using sample_app.Models;

namespace sample_app.Data
{
    public class SampleAppContext: DbContext
    {
        public SampleAppContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
