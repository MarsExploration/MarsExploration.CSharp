using MarsExploration.Domain.Commands;
using MarsExploration.Domain.CQS;
using Microsoft.AspNetCore.Mvc;

namespace MarsExploration.WebApi
{
    [Route("api/[controller]")]
    public class ProbeController : Controller
    {
        private readonly ICommandHandler<MoveProbesCommand, MoveProbesCommandResult> _moveProbesCommandHandler;

        public ProbeController(ICommandHandler<MoveProbesCommand, MoveProbesCommandResult> moveProbesCommandHandler)
        {
            _moveProbesCommandHandler = moveProbesCommandHandler;
        }

        [HttpPost]
        public MoveProbesCommandResult Move([FromBody]MoveProbesCommand command)
        {
            var result = _moveProbesCommandHandler.Handle(command);
            return result;
        }
    }
}
