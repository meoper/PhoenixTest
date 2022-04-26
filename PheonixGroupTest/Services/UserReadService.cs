using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PheonixGroupTest.Entities;

namespace PheonixGroupTest.Services
{
    public sealed class UserReadService
    {
        private readonly DBContext dbContext;

        public UserReadService(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Normally would have separation of domain level entities and DTO objects, but will do fine for this use case
        public async Task<List<User>> GetUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }
    }
}
