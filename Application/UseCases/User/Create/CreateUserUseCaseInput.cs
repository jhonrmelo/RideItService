using Domain.Entity;
using Domain.Enum;

using System;

namespace Application.UseCases.User.Create
{
    public class CreateUserUseCaseInput
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public UsersEntity CreateUser() => new UsersEntity()
        {
            Email = Email,
            Name = Name,
            Password = Password,
            BirthDate = BirthDate,
            Gender = Gender,
            Status = true
        };
    }
}