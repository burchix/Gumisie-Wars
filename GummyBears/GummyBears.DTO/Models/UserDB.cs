﻿using GummyBears.Common.Interfaces;
using System.Collections.Generic;

namespace GummyBears.DTO.Models
{
    public class UserDB : IObjWithId
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
