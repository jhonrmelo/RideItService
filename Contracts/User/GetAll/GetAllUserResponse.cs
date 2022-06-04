using Domain.Dto;

using System.Collections.Generic;

namespace Contracts.User.GetAll
{
    public class GetAllUserResponse
    {
        public IEnumerable<UsersDto> Users { get; set; }
    }
}