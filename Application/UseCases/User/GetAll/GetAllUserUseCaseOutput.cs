using Domain.Entity;

using System.Collections.Generic;

namespace Application.UseCases.User.GetAll
{
    public class GetAllUserUseCaseOutput
    {
        public GetAllUserUseCaseOutput(bool returned, IEnumerable<UsersEntity> users)
        {
            Returned = returned;
            Users = users;
        }

        public GetAllUserUseCaseOutput(bool returned)
        {
            Returned = returned;
        }

        public IEnumerable<UsersEntity> Users { get; set; }
        public bool Returned { get; set; }

        public static GetAllUserUseCaseOutput Ok(IEnumerable<UsersEntity> users) => new GetAllUserUseCaseOutput(returned: true, users: users);

        public static GetAllUserUseCaseOutput Fail() => new GetAllUserUseCaseOutput(returned: false);
    }
}