using MediatR;
using OSPeConTI.Auth.Services.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace OSPeConTI.Auth.Services.Application.Commands
{
    [DataContract]
    public class RegisterCommand : IRequest<Guid>
    {
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string NombreUsuario { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        public RegisterCommand()
        {

        }


    }
}