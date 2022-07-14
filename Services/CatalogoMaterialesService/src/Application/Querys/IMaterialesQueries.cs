namespace OSPeConTI.Auth.Services.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.Auth.Services.Domain.Entities;

    public interface IMaterialesQueries
    {
        Task<MaterialesDTO> GetMaterialesAsync(int codigo);
        Task<IEnumerable<MaterialesDTO>> GetMaterialesByNameAsync(string nombre);
        Task<IEnumerable<MaterialesDTO>> GetAll();
        Task<IEnumerable<MaterialesDTO>> GetMaterialeByDescripcionesCombinadasAsync(string descripcion);


    }
}