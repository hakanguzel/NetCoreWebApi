using System;
using BasicApi.Business.Abstract;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Concrete
{
    public class UserService : IUserService
    {
        public ServiceResponse<UserDto> Authenticate(string email, string pass)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<UserDto> Changepassword(int userId, ChangePasswordDto model)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<UserDto> Register(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
