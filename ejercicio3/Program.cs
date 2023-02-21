using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int a, b, c, d, contador = 0;


            Console.WriteLine ("Ingrese numero 1:");
            a = int.Parse (Console.ReadLine());

            Console.WriteLine ("Ingrese numero 2:");
            b = int.Parse (Console.ReadLine());

            Console.WriteLine ("Ingrese numero 3:");
            c = int.Parse (Console.ReadLine());

            Console.WriteLine ("Ingrese numero 4:");
            d = int.Parse (Console.ReadLine());

            if ( a > 100) {
                 
                  Console.WriteLine (+ a + " es mayor a 100");
                   contador++;
            }
            if (b > 100){
                   
                   Console.WriteLine (+ b + " es mayor a 100");
                   contador++;
            }
            if (c > 100) {
               
                Console.WriteLine (+ c + " es mayor a 100");
                  contador++;
            }
            if (d > 100){
                  
                  Console.WriteLine (+ d + " es mayor a 100");
                  contador++;
            }
            
             if (contador != 0)
                  
                  Console.WriteLine ("hubo " + contador +  " mayor/es a 100");


             if (contador == 0)

                 Console.WriteLine ("no hubo mayor/es a 100");
                





        }
    }
}
