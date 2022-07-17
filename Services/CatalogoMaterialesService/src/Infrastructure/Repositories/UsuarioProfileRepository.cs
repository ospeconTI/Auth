using Microsoft.EntityFrameworkCore;
using OSPeConTI.Auth.Services.Domain.Entities;
using OSPeConTI.Auth.Services.Domain.SeedWork;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace OSPeConTI.Auth.Services.Infrastructure.Repositories
{
    public class UsuarioProfileRepository
        : IUsuarioProfileRepository
    {
        private readonly AuthContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public UsuarioProfileRepository(AuthContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Guid add(UsuarioProfile usuarioProfile)
        {
            _context.UsuarioProfiles.Add(usuarioProfile);
            return usuarioProfile.Id;
        }
        public void update(UsuarioProfile usuarioProfile)
        {
            _context.UsuarioProfiles.Update(usuarioProfile);
        }

        public async Task<UsuarioProfile> getByIdAsync(Guid id)
        {
            var item = await _context
                                .UsuarioProfiles
                                .FirstOrDefaultAsync(o => o.Id == id);
            if (item == null)
            {
                item = _context
                            .UsuarioProfiles
                            .Local
                            .FirstOrDefault(o => o.Id == id);
            }

            return item;
        }

        public async Task<UsuarioProfile> getByNombreUsuarioAsync(string nombreUsuario)
        {
            var tipo = await _context
                    .UsuarioProfiles
                    .FirstOrDefaultAsync(o => o.NombreUsuario == nombreUsuario);
            if (tipo == null)
            {
                tipo = _context
                            .UsuarioProfiles
                            .Local
                            .FirstOrDefault(o => o.NombreUsuario == nombreUsuario);
            }

            return tipo;
        }

    }
}