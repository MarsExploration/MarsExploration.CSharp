using MarsExploration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Commands
{
    public class MoveProbesCommandResult
    {
        public IEnumerable<Position> ProbesFinalPositions { get; set; }
    }
}
