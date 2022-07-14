using MediatR;
namespace OSPeConTI.Auth.Services.Domain.Entities
{

    public class ClasificacionAgregadoRequested : INotification
    {
        public Clasificacion Clasificacion { get; set; }
        public ClasificacionAgregadoRequested(Clasificacion clasificacion)
        {
            Clasificacion = clasificacion;
        }
    }

}
