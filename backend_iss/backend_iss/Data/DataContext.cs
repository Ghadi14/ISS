using backend_iss.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_iss.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
