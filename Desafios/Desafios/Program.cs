using System;

class HelloWord
{
    static void Main()
    {
        CalculoDeMeses(5000, 8000, 10000);
        Console.ReadKey(true);

    }
    public static void CalculoDeMeses(int mesUno, int mesDos, int mesTres)
    {
        string nombre;

        int suma = mesUno + mesDos + mesTres;
        int promedio = suma / 3;
        Console.WriteLine("Escriba su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola {0} su total ganaste {1} y promediaste {2}", nombre, suma, promedio);
    }


}
