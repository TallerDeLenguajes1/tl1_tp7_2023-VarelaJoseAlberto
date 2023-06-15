using EspacioEmpleado;
using System;

public class Program
{
    public static void Main()
    {
        const int numEmpleados = 3;
        Empleado[] empleados = new Empleado[numEmpleados];

        // Cargar datos de empleados
        CargarDatosEmpleados(empleados);

        // Calcular el monto total de los salarios
        double montoTotalSalarios = CalcularMontoTotalSalarios(empleados);

        // Mostrar los datos del empleado más próximo a jubilarse
        Empleado empleadoProximoJubilarse = ObtenerEmpleadoProximoJubilarse(empleados);

        // Mostrar resultados por pantalla
        MostrarDatosEmpleados(empleados);
        Console.WriteLine("Monto total de salarios: $" + montoTotalSalarios);
        MostrarDatosEmpleado(empleadoProximoJubilarse);
    }

    public static void CargarDatosEmpleados(Empleado[] empleados)
    {
        for (int i = 0; i < empleados.Length; i++)
        {
            Empleado empleado = new Empleado();

            Console.WriteLine("Empleado #" + (i + 1));
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            empleado.Apellido = Console.ReadLine();

            Console.Write("Fecha de nacimiento (yyyy-mm-dd): ");
            empleado.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.Write("Estado civil (C = Casado, S = Soltero): ");
            empleado.EstadoCivil = Console.ReadLine()[0];

            Console.Write("Género (M = Masculino, F = Femenino): ");
            empleado.Genero = Console.ReadLine()[0];

            Console.Write("Fecha de ingreso en la empresa (yyyy-mm-dd): ");
            empleado.FechaIngreso = DateTime.Parse(Console.ReadLine());

            Console.Write("Sueldo básico: ");
            empleado.SueldoBasico = double.Parse(Console.ReadLine());

            Console.Write("Cargo (0- Auxiliar, 1- Administrativo, 2- Ingeniero, 3- Especialista, 4- Investigador): ");
            empleado.Cargo = (Cargos)Enum.Parse(typeof(Cargos), Console.ReadLine());

            empleados[i] = empleado;
            Console.WriteLine();
        }
    }

    public static double CalcularMontoTotalSalarios(Empleado[] empleados)
    {
        double montoTotal = 0;

        foreach (Empleado empleado in empleados)
        {
            double salario = empleado.CalcularSalario();
            montoTotal += salario;
        }

        return montoTotal;
    }

    public static Empleado ObtenerEmpleadoProximoJubilarse(Empleado[] empleados)
    {
        Empleado empleadoProximoJubilarse = null;
        int menorAniosParaJubilarse = int.MaxValue;

        foreach (Empleado empleado in empleados)
        {
            int aniosParaJubilarse = empleado.CalcularAniosParaJubilarse();

            if (aniosParaJubilarse < menorAniosParaJubilarse)
            {
                menorAniosParaJubilarse = aniosParaJubilarse;
                empleadoProximoJubilarse = empleado;
            }
        }

        return empleadoProximoJubilarse;
    }

    public static void MostrarDatosEmpleados(Empleado[] empleados)
    {
        Console.WriteLine("Datos de los empleados:");
        Console.WriteLine();

        foreach (Empleado empleado in empleados)
        {
            MostrarDatosEmpleado(empleado);
            Console.WriteLine();
        }
    }

    public static void MostrarDatosEmpleado(Empleado empleado)
    {
        Console.WriteLine("Nombre: " + empleado.Nombre);
        Console.WriteLine("Apellido: " + empleado.Apellido);
        Console.WriteLine("Fecha de nacimiento: " + empleado.FechaNacimiento.ToString("yyyy-MM-dd"));
        Console.WriteLine("Estado civil: " + empleado.EstadoCivil);
        Console.WriteLine("Género: " + empleado.Genero);
        Console.WriteLine("Fecha de ingreso en la empresa: " + empleado.FechaIngreso.ToString("yyyy-MM-dd"));
        Console.WriteLine("Sueldo básico: " + empleado.SueldoBasico);
        Console.WriteLine("Cargo: " + empleado.Cargo);
        Console.WriteLine("Antigüedad: " + empleado.CalcularAntiguedad() + " años");
        Console.WriteLine("Edad: " + empleado.CalcularEdad() + " años");
        Console.WriteLine("Años para jubilarse: " + empleado.CalcularAniosParaJubilarse());
        Console.WriteLine("Salario: " + empleado.CalcularSalario());
    }
}

