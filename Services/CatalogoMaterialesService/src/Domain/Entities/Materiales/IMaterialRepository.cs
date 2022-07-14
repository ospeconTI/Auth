using OSPeConTI.BackEndBase.Services.Usuarios.Domain.SeedWork;
using OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities
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