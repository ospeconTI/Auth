using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OSPeConTI.Auth.Services.Domain.Entities;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public interface IUsuarioProfileRepository : IRepository<UsuarioProfile>
    {
        Guid add(UsuarioProfile usuarioProfile);

        void update(UsuarioProfile usuarioProfile);
        Task<UsuarioProfile> getByNombreUsuarioAsync(string nombreUsuario);
        Task<UsuarioProfile> getByIdAsync(Guid id);
    }
}
