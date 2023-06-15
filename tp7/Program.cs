// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora Ndato = new Calculadora();
double dato;
string? numString;
int Opcion;
bool control, control2 = true;

while (control2)
{


    Console.WriteLine(" 1- Sumar\n 2- Restar\n 3- Multipiclar\n 4- Dividir\n 5- Limpiar\n 0- Salir");
    Opcion = Console.ReadKey().KeyChar;
    Thread.Sleep(500);
    switch (Opcion)
    {
        case '1':
            Console.WriteLine("\ningrese el numero a sumar");
            do
            {
                numString = Console.ReadLine();
                control = double.TryParse(numString, out dato);
                if (control)
                {
                    Ndato.Sumar(dato);
                    Console.WriteLine("El Resultado es: " + Ndato.Resultado);
                }
            } while (numString != " ");
            break;
        case '2':
            Console.WriteLine("\ningrese el numero a restar");
            do
            {
                numString = Console.ReadLine();
                control = double.TryParse(numString, out dato);
                if (control)
                {
                    Ndato.Restar(dato);
                    Console.WriteLine("El Resultado es: " + Ndato.Resultado);
                }
            } while (numString != " ");
            break;
        case '3':
            Console.WriteLine("\ningrese el numero a multiplicar");
            do
            {
                numString = Console.ReadLine();
                control = double.TryParse(numString, out dato);
                if (control)
                {
                    Ndato.Multiplicar(dato);
                    Console.WriteLine("El Resultado es: " + Ndato.Resultado);
                }
            } while (numString != " ");
            break;
        case '4':
            Console.WriteLine("\ningrese el numero a dividir");
            do
            {
                numString = Console.ReadLine();
                control = double.TryParse(numString, out dato);
                if (control)
                {
                    Ndato.Dividir(dato);
                    Console.WriteLine("El Resultado es: " + Ndato.Resultado);
                }
            } while (numString != " ");
            break;
        case '5':
            Ndato.Limpiar();
            Console.WriteLine("Se limplio el Resultado");
            break;
        case '0':
            control2 = false;
            break;
        default:
            break;
    }


}