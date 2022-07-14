using MediatR;
using OSPeConTI.Auth.Services.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace OSPeConTI.Auth.Services.Application.Commands
{
    // Regular CommandHandler
    public class AddTipoMaterialCommandHandler : IRequestHandler<AddTipoMaterialCommand, bool>
    {
        private readonly ITipoMaterialRepository _tipoMaterialesRepository;

        public AddTipoMaterialCommandHandler(ITipoMaterialRepository tipoMaterialRepository)
        {
            _tipoMaterialesRepository = tipoMaterialRepository;
        }

        public async Task<bool> Handle(AddTipoMaterialCommand command, CancellationToken cancellationToken)
        {

            TipoMaterial tipoMaterial = new TipoMaterial(command.Descripcion);

            _tipoMaterialesRepository.Add(tipoMaterial);

            return await _tipoMaterialesRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}