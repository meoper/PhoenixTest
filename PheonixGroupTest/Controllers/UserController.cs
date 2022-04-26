using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using PheonixGroupTest.Entities;
using PheonixGroupTest.Services;

namespace PheonixGroupTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserReadService userReadService;
        private readonly UserService userService;

        public UserController(UserReadService userReadService, UserService userService)
        {
            this.userReadService = userReadService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetList()
        {
            return await userReadService.GetUsersAsync();
        }

        [HttpPost]
        [Route("generate")]
        public async Task GenerateUsers(int count)
        {
            await userService.GenerateUsersAsync(count);
        }
    }
}
