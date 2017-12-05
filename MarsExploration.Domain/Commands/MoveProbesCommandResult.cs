using MarsExploration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Commands
{
    /// <summary>
    /// Dados do resultado da movimentação da sonda
    /// </summary>
    public class MoveProbesCommandResult
    {
        public IEnumerable<Position> ProbesFinalPositions { get; set; }
    }
}
