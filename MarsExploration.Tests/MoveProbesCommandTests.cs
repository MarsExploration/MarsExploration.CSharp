using MarsExploration.Domain.Commands;
using MarsExploration.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MarsExploration.Tests
{
    [TestClass]
    public class MoveProbesCommandTests
    {
        [TestMethod]
        public void SampleInputShouldRetrieveExpectedResults()
        {
            var commandHandler = new MoveProbesCommandHandler(new DirectionTurner(), new ProbeMover());

            var command = new MoveProbesCommand
            {
                SuperiorRightLimit = new Coordinates { X = 5, Y = 5 },
                ProbesData = new List<ProbeData>
                {
                    new ProbeData
                    {
                        InitialPosition = new Position {Coordinates = new Coordinates{X = 1, Y = 2}, Direction = Direction.North},
                        Actions = new List<ProbeAction>
                        {
                            ProbeAction.TurnLeft, ProbeAction.Move,
                            ProbeAction.TurnLeft, ProbeAction.Move,
                            ProbeAction.TurnLeft, ProbeAction.Move,
                            ProbeAction.TurnLeft, ProbeAction.Move,
                            ProbeAction.Move
                        }
                    },
                    new ProbeData
                    {
                        InitialPosition = new Position {Coordinates = new Coordinates{X = 3, Y = 3}, Direction = Direction.East},
                        Actions = new List<ProbeAction>
                        {
                           ProbeAction.Move, ProbeAction.Move, ProbeAction.TurnRight,
                           ProbeAction.Move, ProbeAction.Move, ProbeAction.TurnRight,
                           ProbeAction.Move, ProbeAction.TurnRight,
                           ProbeAction.TurnRight, ProbeAction.Move
                        }
                    }
                }
            };
            var result = commandHandler.Handle(command);

            var firstProbe = result.ProbesFinalPositions.First();
            Assert.IsTrue(firstProbe.Coordinates.X == 1 &&
                        firstProbe.Coordinates.Y == 3 &&
                        firstProbe.Direction == Direction.North);

            var secondProbe = result.ProbesFinalPositions.ElementAt(1);
            Assert.IsTrue(secondProbe.Coordinates.X == 5 &&
                          secondProbe.Coordinates.Y == 1 &&
                          secondProbe.Direction == Direction.East);
        }
    }
}
