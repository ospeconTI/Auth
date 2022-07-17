using Microsoft.EntityFrameworkCore;
using OSPeConTI.Auth.Services.Domain.Entities;
using OSPeConTI.Auth.Services.Domain.SeedWork;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OSPeConTI.Auth.Services.Infrastructure.Repositories
{
    public class AuthDataRepository
        : IAuthDataRepository
    {
        private readonly AuthContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public AuthDataRepository(AuthContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<AuthData> getByIdAsync(Guid id)
        {
            var item = await _context
                                .AuthDatas
                                .FirstOrDefaultAsync(o => o.Id == id);



            return item;
        }
        public Guid add(AuthData authData)
        {
            _context.AuthDatas.Add(authData);
            return authData.Id;
        }


    }
}