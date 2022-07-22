using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
namespace OSPeConTI.Auth.Services.Domain
{
    public class NoEncrypt : IEncrypt
    {

        HashSalt IEncrypt.EncryptPassword(string password)
        {

            return new HashSalt { };
        }

        bool IEncrypt.VerifyPassword(string enteredPassword, string salt, string storedPassword)
        {
            return true;
        }
    }
}