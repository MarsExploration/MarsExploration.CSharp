using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    /// <summary>
    /// Abstração da ação de movimentar uma sonda
    /// </summary>
    public interface IProbeMover
    {
        Position Move(Position previousPosition, Coordinates UpperRightLight);
    }
}
