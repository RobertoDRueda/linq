using System.Diagnostics.CodeAnalysis;

namespace CONTAINS
{
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    public class PuntoComparer : IEqualityComparer<Punto>
    {
        public bool Equals(Punto? punto1, Punto? punto2)
        {
            return punto1.X == punto2.X && punto1.Y == punto2.Y;
        }

        public int GetHashCode([DisallowNull] Punto obj)
        {
            return obj.X ^ obj.Y;
        }
    }
}
