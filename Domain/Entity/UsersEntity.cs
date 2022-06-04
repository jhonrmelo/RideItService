using Dapper.Contrib.Extensions;

using Domain.Enum;

using System;

namespace Domain.Entity
{
    [Table("Users")]
    public class UsersEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public bool Status { get; set; }
    }
}