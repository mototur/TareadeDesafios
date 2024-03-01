using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserta el primer numero: ");
                int numeroUno = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserta el segundo numero: ");
                int numeroDos = int.Parse(Console.ReadLine());

                sumaDeValores(numeroUno, numeroDos);

                Console.ReadKey(true);

                    
            }

            catch (Exception ex) 
            {
                Console.WriteLine("Has insertado un espacio o un caracter de tipo string");
                Console.ReadKey(true);


            }

        }
        static void sumaDeValores(int num1, int num2)
        {

            Console.WriteLine("La suma de los dos valores es: " + (num1 + num2));
        }
    }

}
