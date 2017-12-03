using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExploration.Domain.Models
{
    public class Position
    {
        public Coordinates Coordinates { get; set; }
        public Direction Direction { get; set; }
    }
}
