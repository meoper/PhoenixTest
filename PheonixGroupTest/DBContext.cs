using Microsoft.EntityFrameworkCore;
using PheonixGroupTest.Entities;

namespace PheonixGroupTest
{
    public class DBContext: DbContext
    {
        // I personally prefer plural table names, but make no difference
        public DbSet<User> Users { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
    }
}
