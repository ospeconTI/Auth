namespace OSPeConTI.Auth.Services.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.Auth.Services.Domain.Entities;

    public interface ITipoMaterialesQueries
    {
        Task<tipoMaterialDTO> GetTipoMaterialesAsync(Guid Id);
        Task<IEnumerable<tipoMaterialDTO>> GetTipoMaterialesByNameAsync(string descripcion);
        Task<IEnumerable<tipoMaterialDTO>> GetAll();


    }
}