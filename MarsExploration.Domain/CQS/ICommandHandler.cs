using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.CQS
{
    public interface ICommandHandler<TCommand, TResult>
    {
        TResult Handle(TCommand command);
    }
}
