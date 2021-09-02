using System;
using System.Collections.Generic;
using System.Text;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Abstract
{
    public interface IUserService
    {
        ServiceResponse<UserDto> Authenticate(string email, string pass);
        ServiceResponse<UserDto> Register(UserDto model);
        ServiceResponse<UserDto> Changepassword(int userId, ChangePasswordDto model);
    }
}
