using MarsExploration.Domain.CQS;
using MarsExploration.Domain.Models;
using System;
using System.Linq;

namespace MarsExploration.Domain.Commands
{
    /// <summary>
    /// Classe responsável por executar o comando de movimentação das sondas e retornar o resultado
    /// </summary>
    public class MoveProbesCommandHandler : ICommandHandler<MoveProbesCommand, MoveProbesCommandResult>
    {
        private readonly IDirectionTurner _directionTurner;
        private readonly IProbeMover _probeMover;

        public MoveProbesCommandHandler(IDirectionTurner directionTurner,
                                        IProbeMover probeMover)
        {
            _directionTurner = directionTurner;
            _probeMover = probeMover;
        }

        private Position ExecuteProbeAction(Coordinates upperRightLimit, Position previousPosition, ProbeAction action)
        {
            switch (action)
            {
                case ProbeAction.Move:
                    return _probeMover.Move(previousPosition, upperRightLimit);
                case ProbeAction.TurnLeft:
                    return new Position
                    {
                        Coordinates = previousPosition.Coordinates,
                        Direction = _directionTurner.TurnLeft(previousPosition.Direction)
                    };
                case ProbeAction.TurnRight:
                    return new Position
                    {
                        Coordinates = previousPosition.Coordinates,
                        Direction = _directionTurner.TurnRight(previousPosition.Direction)
                    };
            }

            throw new Exception($"Unknown action {action}");
        }

        public MoveProbesCommandResult Handle(MoveProbesCommand command)
        {
            var probesFinalPositions = command.ProbesData
                                              .Select(data => data.Actions.Aggregate(data.InitialPosition,
                                                                             (currentPosition, action) => 
                                                                                 ExecuteProbeAction(command.SuperiorRightLimit, 
                                                                                                    currentPosition, 
                                                                                                    action)));

            return new MoveProbesCommandResult { ProbesFinalPositions = probesFinalPositions };
        }
    }
}
