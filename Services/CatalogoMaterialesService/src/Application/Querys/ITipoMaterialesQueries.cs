namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;

    public interface ITipoMaterialesQueries
    {
        Task<tipoMaterialDTO> GetTipoMaterialesAsync(Guid Id);
        Task<IEnumerable<tipoMaterialDTO>> GetTipoMaterialesByNameAsync(string descripcion);
        Task<IEnumerable<tipoMaterialDTO>> GetAll();


    }
}