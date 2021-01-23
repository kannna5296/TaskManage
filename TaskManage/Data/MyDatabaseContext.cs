using Microsoft.EntityFrameworkCore;
using TaskManage.Models;

namespace TaskManage.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options): base(options)
        {
        }

        public MyDatabaseContext()
        {

        }

        public virtual DbSet<Todo> Todo { get; set; }
    }
}
