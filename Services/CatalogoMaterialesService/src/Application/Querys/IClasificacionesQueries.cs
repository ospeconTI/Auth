namespace OSPeConTI.Auth.Services.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.Auth.Services.Domain.Entities;

    public interface IClasificacionesQueries
    {
        Task<ClasificacionDTO> GetClasificacionesAsync(Guid id);
        Task<IEnumerable<ClasificacionDTO>> GetClasificacionesByNameAsync(string descripcion);
        Task<IEnumerable<ClasificacionDTO>> GetAll();

    }
}