using System;

namespace OSPeConTI.Auth.Services.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class RecoveryCodeDomainException : Exception
    {
        public RecoveryCodeDomainException()
        { }

        public RecoveryCodeDomainException(string message)
            : base(message)
        { }

        public RecoveryCodeDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}