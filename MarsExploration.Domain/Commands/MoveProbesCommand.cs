using MarsExploration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Commands
{
    /// <summary>
    /// Dados utilizados na movimentação das sondas
    /// </summary>
    public class MoveProbesCommand
    {
        public Coordinates SuperiorRightLimit { get; set; }
        public IEnumerable<ProbeData> ProbesData { get; set; }
    }
}
