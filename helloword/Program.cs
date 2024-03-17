namespace helloword{ 
    class Program{ 

    static void Main(){ 
          
           DateOnly dateConverted = new DateOnly();
           string nameImput;
           string  birthdayInput;
          Console.WriteLine("bienvenido al calculador de años");
          Console.WriteLine("escribe tu nombre: ");
          nameImput = Console.ReadLine();
          Console.WriteLine($"un gusto conocerete! {nameImput}");
          Console.WriteLine("escribe tu fecha de nacimiento en dd/mm/yy: ");
           birthdayInput= Console.ReadLine();
           bool isdatevalid=DateOnly.TryParse(birthdayInput,out dateConverted);
           if(isdatevalid==false) Console.WriteLine($"la fecha es invalida {birthdayInput}");
           Console.ReadLine();
       }
     }
    

    public class Person{
      public string name{get; set;}
      public int Age{get; set;}

      public DateOnly birthday {get; set;}
      }
    }

