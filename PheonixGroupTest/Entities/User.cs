using System;
using System.ComponentModel.DataAnnotations;

namespace PheonixGroupTest.Entities
{
    // In a proper domain environment, would probably make entities with private constructors and static construction functions
    // To provide a nice way of control on validations and simple testing
    public sealed class User
    {
        public Guid Id { get; set; }

        // Using data annotations as a simple way to make EF not use nvarchar(max)
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(60)]
        public string PhoneNumber { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }
    }
}
