﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApi.Data.DtoModels
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
