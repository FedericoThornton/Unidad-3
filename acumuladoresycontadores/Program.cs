using System;

namespace acumuladoresycontadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // acumuladores y contadores
            // operador de acumulador
            // ++
            // --
            // operador de contador
            // +=
            // -=

            int Contador = 0, e1 = 25, e2 = 12, e3 = 50; 
            float Acumulador = 0, promedio;

            if (e1 > 18){ 
                Contador ++;
                Acumulador = Acumulador + e1;
            }
            if (e2 > 18){ 
                Contador ++;
                Acumulador += e2;
            }
            if (e3 > 18){
                Contador ++;
                Acumulador += e3;
            }

            promedio = Acumulador / Contador;

            Console.WriteLine ("El promedio es: " + promedio);


        }
    }
}
