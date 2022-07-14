using System;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Exceptions
{
    public class ForbiddenException : Exception, IForbiddenException
    {

        public string Url { get => "https://miDominio/api/v1/login"; }


        public ForbiddenException()
        { }

        public ForbiddenException(string message)
            : base(message)
        { }

        public ForbiddenException(string message, Exception innerException)
            : base(message, innerException)
        { }

    }
}
