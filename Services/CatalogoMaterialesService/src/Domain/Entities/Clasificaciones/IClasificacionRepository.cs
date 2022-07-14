using OSPeConTI.Auth.Services.Domain.SeedWork;
using OSPeConTI.Auth.Services.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public interface IClasificacionRepository : IRepository<Clasificacion>
    {
        Clasificacion Add(Clasificacion clasificacion);
        Clasificacion Update(Clasificacion clasificacion);

        Task<Clasificacion> GetAsync(Guid Id);

        Task<Clasificacion> GetByNameAsync(string descrip);

    }
}