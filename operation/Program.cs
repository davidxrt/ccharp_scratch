Console.WriteLine("Ingrese el primer número: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo número: ");
        double b = double.Parse(Console.ReadLine());
        
        const string indeterminado = "indeterminado";
        
        Console.WriteLine($"Suma: {a + b}, Resta: {a - b}, Multiplicación: {a * b}, División: {(b != 0 ? (a / b).ToString() : indeterminado)}");
