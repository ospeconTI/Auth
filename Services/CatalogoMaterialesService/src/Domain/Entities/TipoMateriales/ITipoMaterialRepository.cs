using OSPeConTI.BackEndBase.Services.Usuarios.Domain.SeedWork;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities
{
    public interface ITipoMaterialRepository : IRepository<TipoMaterial>
    {
        TipoMaterial Add(TipoMaterial tipoMaterial);
        TipoMaterial Update(TipoMaterial tipoMaterial);

        Task<TipoMaterial> GetByIdAsync(Guid Id);
        Task<TipoMaterial> GetTipoMaterialesByNameAsync(string descripcion);
    }
}