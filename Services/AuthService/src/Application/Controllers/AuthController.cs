using MediatR;
using Microsoft.AspNetCore.Mvc;
using OSPeConTI.Auth.Services.Application.Queries;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using OSPeConTI.Auth.Services.Application.Commands;

namespace OSPeConTI.Auth.Services.Application
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AuthController> _logger;

        private readonly IAuthQueries _authQueries;

        public AuthController(
            IMediator mediator,
            ILogger<AuthController> logger,
            IAuthQueries authQueries)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _authQueries = authQueries ?? throw new ArgumentNullException(nameof(authQueries));
        }

        [Route("login")]
        [HttpPost]
        public async Task<ActionResult> LoginAsync([FromBody] Credentials credenciales)
        {
            var token = await _authQueries.LoginAsync(credenciales.usuario, credenciales.password);

            return Ok(token);

        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> RegisterAsync([FromBody] RegisterCommand command)
        {
            Guid UID = await _mediator.Send(command);
            return Ok(UID);

        }

        [Route("activate")]
        [HttpPost]
        public async Task<ActionResult> ActivateAsync([FromBody] ActivateUserCommand command)
        {
            bool res = await _mediator.Send(command);
            return Ok();

        }



    }
}