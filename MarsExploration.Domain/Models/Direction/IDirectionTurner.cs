using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    public interface IDirectionTurner
    {
        Direction TurnRight(Direction previousDirection);
        Direction TurnLeft(Direction previousDirection);
    }
}
