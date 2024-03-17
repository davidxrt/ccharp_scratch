using System;

class Circulo
{
    private double radio;

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }

    // Método para obtener el radio
    public double ObtenerRadio()
    {
        return radio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese el radio del círculo
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());

        // Crear un objeto de la clase Circulo con el radio proporcionado
        Circulo miCirculo = new Circulo(radio);

        // Calcular el área y el perímetro del círculo con el radio proporcionado
        double area = miCirculo.CalcularArea();
        double perimetro = miCirculo.CalcularPerimetro();

        // Mostrar los resultados del círculo en la consola
        Console.WriteLine($"El área del círculo es: {area}");
        Console.WriteLine($"El perímetro del círculo es: {perimetro}");

        // Mostrar números del 0 al 34 de forma vertical
        Console.WriteLine("Contando del 0 al 34:");
        for (int i = 0; i <= 34; i++)
        {
            Console.WriteLine(i);
        }

        // Solicitar al usuario que ingrese dos números para la división
        Console.WriteLine("Ingrese dos números para realizar la división:");
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        // Calcular el resultado de la división
        double resultado = numero1 / numero2;

        // Mostrar el resultado de la división en la consola
        Console.WriteLine($"El resultado de la división de {numero1} entre {numero2} es: {resultado}");
    }
}



