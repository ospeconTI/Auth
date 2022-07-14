using MediatR;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Commands
{
    [DataContract]
    public class UpdateTipoMaterialCommand : IRequest<bool>
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

        public UpdateTipoMaterialCommand()
        {

        }

        public UpdateTipoMaterialCommand(Guid id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}