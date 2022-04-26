using System.Collections.Generic;
using System.Threading.Tasks;
using PheonixGroupTest.Entities;

namespace PheonixGroupTest.Services
{
    public sealed class UserRepository
    {
        private readonly DBContext dbContext;

        public UserRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddUserRangeAsync(List<User> users)
        {
            await dbContext.Users.AddRangeAsync(users);
            await dbContext.SaveChangesAsync();
        }
    }
}
