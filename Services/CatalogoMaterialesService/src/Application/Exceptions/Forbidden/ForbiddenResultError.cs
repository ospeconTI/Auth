using System;
using OSPeConTI.Auth.Services.Application.Attributes;
using OSPeConTI.Auth.Services.Application.Middlewares;

namespace OSPeConTI.Auth.Services.Application.Exceptions
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