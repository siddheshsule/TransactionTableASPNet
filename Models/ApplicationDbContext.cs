using Microsoft.EntityFrameworkCore;

namespace InterviewTable.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        { }
        public DbSet<Record> Records { get; set; }
    }
}
