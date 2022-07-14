namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;

    public interface IMaterialesQueries
    {
        Task<MaterialesDTO> GetMaterialesAsync(int codigo);
        Task<IEnumerable<MaterialesDTO>> GetMaterialesByNameAsync(string nombre);
        Task<IEnumerable<MaterialesDTO>> GetAll();
        Task<IEnumerable<MaterialesDTO>> GetMaterialeByDescripcionesCombinadasAsync(string descripcion);


    }
}