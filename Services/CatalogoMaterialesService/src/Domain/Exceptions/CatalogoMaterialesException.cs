using System;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class MaterialesDomainException : Exception
    {
        public MaterialesDomainException()
        { }

        public MaterialesDomainException(string message)
            : base(message)
        { }

        public MaterialesDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}