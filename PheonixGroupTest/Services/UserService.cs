using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PheonixGroupTest.Entities;
using RandomNameGeneratorLibrary;

namespace PheonixGroupTest.Services
{
    public sealed class UserService
    {
        private readonly PersonNameGenerator personNameGenerator;
        private readonly UserRepository userRepository;
        private readonly Random random;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;

            random = new Random();
            personNameGenerator = new PersonNameGenerator(new Random());
        }

        public async Task GenerateUsersAsync(int count)
        {
            var users = new List<User>();

            for (int i = 0; i < count; i++)
            {
                var name = personNameGenerator.GenerateRandomFirstName();
                var lastName = personNameGenerator.GenerateRandomLastName();

                users.Add(new User
                {
                    Name = name,
                    LastName = lastName,
                    Email = $"{name}.{lastName}@someMail.com",
                    PhoneNumber = random.Next(1000000, 100000000).ToString(),
                });
            }

            await userRepository.AddUserRangeAsync(users);
        }
    }
}
