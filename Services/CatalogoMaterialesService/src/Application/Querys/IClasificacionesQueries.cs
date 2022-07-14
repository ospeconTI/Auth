namespace OSPeConTI.BackEndBase.Services.Usuarios.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;

    public interface IClasificacionesQueries
    {
        Task<ClasificacionDTO> GetClasificacionesAsync(Guid id);
        Task<IEnumerable<ClasificacionDTO>> GetClasificacionesByNameAsync(string descripcion);
        Task<IEnumerable<ClasificacionDTO>> GetAll();

    }
}