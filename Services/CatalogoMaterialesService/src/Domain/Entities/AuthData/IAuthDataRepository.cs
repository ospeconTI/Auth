using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPeConTI.Auth.Services.Domain.Entities;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public interface IAuthDataRepository : IRepository<AuthData>
    {
        Guid add(AuthData authData);
        Task<AuthData> getByIdAsync(Guid id);
    }
}
