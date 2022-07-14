using System;
using System.Collections.Generic;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Queries
{
    public class MaterialesDTO
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public ClasificacionDTO Clasificacion { get; set; }
        public tipoMaterialDTO TipoMaterial { get; set; }

    }




}