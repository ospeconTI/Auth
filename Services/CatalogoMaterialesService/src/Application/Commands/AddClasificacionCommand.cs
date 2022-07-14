using MediatR;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Commands
{
    [DataContract]
    public class AddClasificacionCommand : IRequest<Guid>
    {
        [DataMember]
        public string Descripcion { get; set; }

        public AddClasificacionCommand()
        {

        }
        public AddClasificacionCommand(string descripcion)

        {
            Descripcion = descripcion;
        }

    }
}