// See https://aka.ms/new-console-template for more information
namespace EspacioCalculadora;
public class Calculadora
{

    private double resultado;


    public double Resultado { get => resultado; }

    public void Sumar(double termino)
    {
        resultado = resultado + termino;
    }
    public void Restar(double termino)
    {
        resultado = resultado - termino;
    }
    public void Multiplicar(double termino)
    {
        resultado = resultado * termino;
    }
    public void Dividir(double termino)
    {
        resultado = resultado / termino;
    }
    public void Limpiar()
    {
        resultado = 0;
    }

}