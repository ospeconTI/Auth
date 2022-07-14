using MediatR;
namespace OSPeConTI.Auth.Services.Domain.Entities
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
