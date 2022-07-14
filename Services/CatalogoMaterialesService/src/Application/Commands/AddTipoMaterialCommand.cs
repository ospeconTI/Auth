using MediatR;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Commands
{
    [DataContract]
    public class AddTipoMaterialCommand : IRequest<bool>
    {
        [DataMember]
        public string Descripcion { get; set; }

        public AddTipoMaterialCommand()
        {

        }
        public AddTipoMaterialCommand(string descripcion)

        {
            Descripcion = descripcion;
        }

    }
}