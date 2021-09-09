using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenElara
{
    class Fibonacci
    {
        //Recursividad: Es cuando una función se llama a sí misma
        
        public static void GetFibonacci(int a, int b, int longitud)  
        {  
            if (longitud>0)  
            {  
                Console.Write(a+" ");
                GetFibonacci(b, a + b,longitud-1);  
            }  
        }  

       
        static void Main(string[] args)
        {
            int NumeroCalcular;

            Console.Write("\nCalcula el numero fibonacci de manera recursiva\n");
            Console.Write("Ingresa cuantos numeros de la serie de fibonacci desdeas calcular: \n");
            NumeroCalcular = int.Parse(Console.ReadLine());

            GetFibonacci(0, 1, NumeroCalcular);
            
            Console.ReadKey();

        }
    }
}
