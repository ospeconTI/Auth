using System;
using OSPeConTI.BackEndBase.Services.Usuarios.Application.Attributes;
using OSPeConTI.BackEndBase.Services.Usuarios.Application.Middlewares;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Exceptions
{
    public class ForbiddenResultError : IResultError
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        [NotShowInProduction]
        public string Detail { get; set; }
        public string Solution { get; set; }
        public string url { get; set; }

        public void Map(Exception ex)
        {
            Message = ex.Message;
            StatusCode = 403;
            Solution = "Debe loguearse";
            url = ((IForbiddenException)ex).Url;
            Detail = ex.StackTrace;
        }
    }

}