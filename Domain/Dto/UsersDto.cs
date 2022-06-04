using Domain.Enum;

using System;

namespace Domain.Dto
{
    public class UsersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public bool Status { get; set; }
    }
}