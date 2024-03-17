using System;

class Program
{
    static void Main(string[] args)
    {
       
        string colorBarberoVerde, colorBarberoRojo, colorBarberoAzul;

        for (int i = 1; i <= 3; i++)
        {
    
            colorBarberoVerde = "";
            colorBarberoRojo = "";
            colorBarberoAzul = "";

        
            if (i == 1)
            {
                colorBarberoVerde = "verde";
            }
            else if (i == 2)
            {
                colorBarberoRojo = "rojo";
            }
            else if (i == 3)
            {
                colorBarberoAzul = "azul";
            }

            // Verificamos las condiciones de las afirmaciones
            if (colorBarberoVerde == "verde" && colorBarberoRojo != "rojo" && colorBarberoAzul != "azul")
            {
                Console.WriteLine("El barbero de la Barbería  tiene el cabello azul " + colorBarberoAzul );
                break;
            }
        }
    }
}


