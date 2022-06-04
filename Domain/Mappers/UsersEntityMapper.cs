using Domain.Dto;
using Domain.Entity;

namespace Domain.Mappers
{
    public static class UsersEntityMapper
    {
        public static UsersDto MapToDto(this UsersEntity userEntity)
            => new UsersDto()
            {
                Id = userEntity.Id,
                Email = userEntity.Email,
                BirthDate = userEntity.BirthDate,
                Gender = userEntity.Gender,
                Name = userEntity.Name,
                Status = userEntity.Status
            };
    }
}