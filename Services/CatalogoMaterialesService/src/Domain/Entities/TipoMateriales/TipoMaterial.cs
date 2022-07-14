using System;
using System.Collections.Generic;
using System.Linq;
using OSPeConTI.Auth.Services.Domain.SeedWork;
using OSPeConTI.Auth.Services.Domain.Exceptions;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public class TipoMaterial : Entity, IAggregateRoot
    {
        public string Descripcion { get; set; }
        public List<Material> Materiales { get; }

        public TipoMaterial()
        {
        }
        public TipoMaterial(string descripcion) : this()
        {
            Descripcion = descripcion;
        }
        public void Update(Guid id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}