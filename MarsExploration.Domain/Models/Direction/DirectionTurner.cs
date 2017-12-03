using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    public class DirectionTurner : IDirectionTurner
    {
        public Direction TurnLeft(Direction previousDirection)
        {
            var angle = (int)previousDirection - 90;
            angle = angle == -90 ? 270 : angle;
            return (Direction)angle;
        }

        public Direction TurnRight(Direction previousDirection)
        {
            var angle = (int)previousDirection + 90;
            angle = angle == 360 ? 0 : angle;
            return (Direction)angle;
        }
    }
}
