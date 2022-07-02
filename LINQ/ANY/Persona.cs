namespace ANY
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Soltero: {Soltero}, FechaIngresoALaEmpresa: {FechaIngresoALaEmpresa}";
        }
    }
}
