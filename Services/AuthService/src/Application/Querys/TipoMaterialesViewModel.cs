using System;
using System.Collections.Generic;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Application.Queries
{
    public class tipoMaterialDTO
    {
        public tipoMaterialDTO()
        {
            Id = Guid.Parse("00000000-0000-0000-0000-000000000000");
            Descripcion = "SIN TIPO DE MATERIAL";
        }
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
    }

}