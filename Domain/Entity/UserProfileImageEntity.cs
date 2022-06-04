using Dapper.Contrib.Extensions;

namespace Domain.Entity
{
    [Table("UserProfileImage")]
    public class UserProfileImageEntity
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public string ProfileImageName { get; set; }
        public bool Status { get; set; }

        public void Deactivate()
        {
            Status = false;
        }
    }
}