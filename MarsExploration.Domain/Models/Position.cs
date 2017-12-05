namespace MarsExploration.Domain.Models
{
    /// <summary>
    /// Representação de coordenadas e uma direção
    /// </summary>
    public class Position
    {
        public Coordinates Coordinates { get; set; }
        public Direction Direction { get; set; }
    }
}
