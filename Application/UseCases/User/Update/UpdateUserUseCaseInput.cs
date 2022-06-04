using Domain.Entity;
using Domain.Enum;

using System;

namespace Application.UseCases.User.Update
{
    public class UpdateUserUseCaseInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public bool Status { get; set; }

        public UsersEntity UpdateUser()
        {
            return new UsersEntity
            {
                Email = Email,
                Name = Name,
                Password = Password,
                BirthDate = BirthDate,
                Gender = Gender,
                Id = Id,
                Status = Status
            };
        }
    }
}