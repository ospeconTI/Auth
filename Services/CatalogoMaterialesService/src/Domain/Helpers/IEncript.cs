

namespace OSPeConTI.Auth.Services.Domain
{
    public interface IEncrypt
    {
        HashSalt EncryptPassword(string password);
        bool VerifyPassword(string enteredPassword, byte[] salt, string storedPassword);
    }
}
