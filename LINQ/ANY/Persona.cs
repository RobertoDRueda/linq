namespace ANY
{
    public class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; } = String.Empty;
        public int Edad { get; set; }
        public bool Soltero { get; set; }

        public List<string> Telefonos { get; set; } = new List<string>();
        public DateTime FechaIngresoALaEmpresa { get; set; }

        public int CompareTo(Persona? other)
        {
            return Edad.CompareTo(other?.Edad);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Soltero: {Soltero}, FechaIngresoALaEmpresa: {FechaIngresoALaEmpresa}";
        }
    }
}