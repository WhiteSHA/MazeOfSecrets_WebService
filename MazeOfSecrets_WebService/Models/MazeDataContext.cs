using Microsoft.EntityFrameworkCore;
 
namespace MazeApi.Models
{
    public class MazeDataContext : DbContext
    {
        public MazeDataContext(DbContextOptions<MazeDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<MazeDataItem> MazeDataItems { get; set; }
    }
}
