using System;
using System.Collections.Generic;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Application.Queries
{
    public class LoginDTO
    {
        public string Token { get; set; }

        public LoginDTO(string token)
        {
            Token = token;
        }
    }
    public class Credentials
    {
        public string usuario { get; set; }
        public string password { get; set; }


    }
}