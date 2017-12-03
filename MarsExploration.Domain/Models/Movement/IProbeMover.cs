using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    public interface IProbeMover
    {
        Position Move(Position previousPosition, Coordinates UpperRightLight);
    }
}
