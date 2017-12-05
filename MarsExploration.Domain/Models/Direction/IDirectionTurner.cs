using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    /// <summary>
    /// Abstração da ação de girar uma sonda
    /// </summary>
    public interface IDirectionTurner
    {
        Direction TurnRight(Direction previousDirection);
        Direction TurnLeft(Direction previousDirection);
    }
}
