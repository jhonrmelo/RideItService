using Domain.Dto;

namespace Contracts.User.GetById
{
    public class GetByIdUserResponse
    {
        public UsersDto Users { get; set; }
        public bool HasExecutedWithoutError { get; set; }

        public string Message { get; set; }
    }
}