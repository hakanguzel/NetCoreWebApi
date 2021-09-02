using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApi.Data.DtoModels
{
    public class ChangePasswordDto
    {
        public int userId { get; set; }
        public string oldpassword { get; set; }
        public string newpassword { get; set; }
    }
}
