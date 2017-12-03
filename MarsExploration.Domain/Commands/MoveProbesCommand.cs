using MarsExploration.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Commands
{
    public class MoveProbesCommand
    {
        public Coordinates SuperiorRightLimit { get; set; }
        public IEnumerable<ProbeData> ProbesData { get; set; }
    }
}
