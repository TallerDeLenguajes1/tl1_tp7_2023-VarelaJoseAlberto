namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int CalcularAntiguedad()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan tiempoTranscurrido = fechaActual - FechaIngreso;
            int antiguedad = (int)Math.Floor(tiempoTranscurrido.TotalDays / 365.25);
            return antiguedad;
        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan tiempoTranscurrido = fechaActual - FechaNacimiento;
            int edad = (int)Math.Floor(tiempoTranscurrido.TotalDays / 365.25);
            return edad;
        }

        public int CalcularAniosParaJubilarse()
        {
            int aniosParaJubilarse;
            if (Genero == 'M')
            {
                aniosParaJubilarse = 65 - CalcularEdad();
            }
            else
            {
                aniosParaJubilarse = 60 - CalcularEdad();
            }
            return aniosParaJubilarse;
        }

        public double CalcularSalario()
        {
            double adicional = 0;

            // Calcular porcentaje de antigüedad
            int antiguedad = CalcularAntiguedad();
            if (antiguedad <= 20)
            {
                adicional = SueldoBasico * (antiguedad * 0.01);
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            // Incrementar adicional por cargo
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            // Incrementar adicional por estado civil
            if (EstadoCivil == 'C')
            {
                adicional += 15000;
            }

            double salario = SueldoBasico + adicional;
            return salario;
        }
    }
}
