using MediatR;
namespace OSPeConTI.BackEndBase.Services.Usuarios.Domain.Entities
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
