using OSPeConTI.Auth.Services.Domain.SeedWork;
using OSPeConTI.Auth.Services.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public interface IMaterialesRepository : IRepository<Material>
    {
        Material Add(Material material);
        Material Update(Material material);

        Task<Material> GetByCodigoAsync(int Codigo);
        Task<Material> GetMaterialesByNameAsync(string descripcion);

        Material ValidoCodigoExistenteAsync(int Codigo);
        Task<Material> ValidoDescripcionExistenteAsync(string descripcion);
    }
}