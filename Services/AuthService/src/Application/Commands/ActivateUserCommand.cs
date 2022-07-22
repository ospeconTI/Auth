using MediatR;
using OSPeConTI.Auth.Services.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace OSPeConTI.Auth.Services.Application.Commands
{
    [DataContract]
    public class ActivateUserCommand : IRequest<bool>
    {
        [DataMember]
        public string CodigoRecupero { get; set; }

        [DataMember]
        public string NombreUsuario { get; set; }


        public ActivateUserCommand()
        {

        }


    }
}