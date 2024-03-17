using System;

class Cuadrado
{
    private double lado;

    // Constructor para inicializar el lado del cuadrado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }

    // Método para obtener la longitud del lado del cuadrado
    public double ObtenerLado()
    {
        return lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese la longitud del lado del cuadrado
        Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");
        double longitudLado = double.Parse(Console.ReadLine());

        // Crear un objeto de la clase Cuadrado
        Cuadrado miCuadrado = new Cuadrado(longitudLado);

        // Calcular el área, el perímetro y obtener la longitud del lado del cuadrado
        double area = miCuadrado.CalcularArea();
        double perimetro = miCuadrado.CalcularPerimetro();
        double lado = miCuadrado.ObtenerLado();

        // Mostrar los resultados en la consola
        Console.WriteLine($"El área es: {area}");
        Console.WriteLine($"El perímetro es: {perimetro}");
        Console.WriteLine($"El lado es: {lado}");
    }
}

