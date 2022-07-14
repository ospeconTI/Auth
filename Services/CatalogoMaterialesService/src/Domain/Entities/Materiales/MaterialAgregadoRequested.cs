using MediatR;
namespace OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities
{

    public class MaterialAgregadoRequested : INotification
    {
        public Material Material { get; set; }
        public MaterialAgregadoRequested(Material material)
        {
            Material = material;
        }
    }

}
