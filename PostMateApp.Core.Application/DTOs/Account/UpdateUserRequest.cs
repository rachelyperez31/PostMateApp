﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMateApp.Core.Application.DTOs.Account
{
    public class UpdateUserRequest
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? ProfileImg { get; set; }
        public IFormFile? ProfileImage { get; set; }
    }
}
