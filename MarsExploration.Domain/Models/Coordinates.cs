using System;
using System.ComponentModel.DataAnnotations;

namespace MarsExploration.Domain.Models
{
    public struct Coordinates
    {
        [Range(0, Int32.MaxValue)]
        public int X { get; set; }

        [Range(0, Int32.MaxValue)]
        public int Y { get; set; }
    }
}
