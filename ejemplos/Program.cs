using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
       {
           
         // Bloque IF condicionales 
            
          // <> != == <= >=
          // valor op valor

         int edad;

        
         
            Console.WriteLine ("Ingrese su edad: ");
            edad = int.Parse (Console.ReadLine ());
         
            
            if (edad >= 30){
               Console.WriteLine ("30% OFF");
            } 


            else if (edad > 21){
            
               Console.WriteLine ("21% OFF");
            }else if  (edad == 21){ 
            
               Console.WriteLine ("10% OFF");
            }else
             {
               Console.WriteLine ("5% OFF");
             }
          
                   
         
         
        
           Console.WriteLine ("fin del programa");
               
                       
                               
                      

            

          

       }      
            
    }

}   
