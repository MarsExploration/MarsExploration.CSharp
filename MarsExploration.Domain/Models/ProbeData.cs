using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    public class ProbeData
    {
        public Position InitialPosition { get; set; }
        public IEnumerable<ProbeAction> Actions { get; set; }
    }
}
