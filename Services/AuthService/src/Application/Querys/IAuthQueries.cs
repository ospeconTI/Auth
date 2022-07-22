namespace OSPeConTI.Auth.Services.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using OSPeConTI.Auth.Services.Domain.Entities;

    public interface IAuthQueries
    {
        Task<LoginDTO> LoginAsync(string usuario, string password);

    }
}