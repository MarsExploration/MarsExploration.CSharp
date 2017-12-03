using System;

namespace MarsExploration.Domain.Models
{
    public class ProbeMover : IProbeMover
    {
        public Position Move(Position previousPosition, Coordinates upperRightLimit)
        {
            switch (previousPosition.Direction)
            {
                case Direction.North:
                    var nextYNorth = previousPosition.Coordinates.Y + 1;
                    return new Position
                    {
                        Direction = previousPosition.Direction,
                        Coordinates = new Coordinates
                        {
                            X = previousPosition.Coordinates.X,
                            Y = nextYNorth <= upperRightLimit.Y
                                ? nextYNorth
                                : previousPosition.Coordinates.Y
                        }
                    };
                case Direction.East:
                    var nextXEast = previousPosition.Coordinates.X + 1;
                    return new Position
                    {
                        Direction = previousPosition.Direction,
                        Coordinates = new Coordinates
                        {
                            X = nextXEast <= upperRightLimit.X
                                ? nextXEast
                                : previousPosition.Coordinates.X,
                            Y = previousPosition.Coordinates.Y
                        }
                    };
                case Direction.South:
                    var nextYSouth = previousPosition.Coordinates.Y - 1;
                    return new Position
                    {
                        Direction = previousPosition.Direction,
                        Coordinates = new Coordinates
                        {
                            X = previousPosition.Coordinates.X,
                            Y = nextYSouth >= 0
                                ? nextYSouth
                                : previousPosition.Coordinates.Y
                        }
                    };
                case Direction.Weast:
                    var nextXWeast = previousPosition.Coordinates.X - 1;
                    return new Position
                    {
                        Direction = previousPosition.Direction,
                        Coordinates = new Coordinates
                        {
                            X = nextXWeast >= 0
                                ? nextXWeast
                                : previousPosition.Coordinates.X,
                            Y = previousPosition.Coordinates.Y
                        }
                    };
            }

            throw new Exception($"Unknown direction {previousPosition.Direction}");
        }
    }
}
