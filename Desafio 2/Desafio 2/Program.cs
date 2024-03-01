using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    internal class Program
    {
        static void Main(string[]args)
        {


            Calculadora ejercicios = new Calculadora();
            Console.WriteLine("suma:" + ejercicios.suma(7, 8));
            Console.WriteLine("resta:" + ejercicios.resta(1, 2));
            Console.WriteLine("multiplicacion: " + ejercicios.multiplicacion(7, 8));
            Console.WriteLine("division: " + ejercicios.division(7, 8));

            Console.ReadKey(true);

        }
        class Calculadora { 

            public int suma (int num1, int num2)
            {
                return num1 + num2; 
            }

            public int resta(int num1, int num2)
            { 
                return num1 - num2;
            }
            public int multiplicacion (int num1, int num2)
            {
                return num1 * num2;

            }
            public int division (int num1, int num2) 
            {
                return num1 / num2;
            }
        }   
    }
}