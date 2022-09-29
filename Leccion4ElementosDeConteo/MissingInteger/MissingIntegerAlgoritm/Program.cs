using MissingIntegerLibrary;
using System.Collections.Generic;

Console.WriteLine("Menor Entero Positivo Faltante (MEPF)");
Algoritmo algoritmo = new();
List<int> A = new();
string opcion = "S";
int obtenido;
string agregar;
Console.WriteLine("¡Desea Buscar el MEPF de una matriz? S-Si Otro-No");
opcion = Console.ReadLine();
while (opcion.ToUpper() == "S")
{
    foreach (var item in A)
    {
        Console.Write("{0} ",item);
    }
    Console.WriteLine();
    Console.WriteLine("Agrega un numero a tu matriz");
    agregar = Console.ReadLine();
    int number;
    bool success = int.TryParse(agregar, out number);
    if (success)
    {
        number = int.Parse(agregar);
        A.Add(number);
        Console.WriteLine("¿Agregar otro numero a la matriz?S-Si Otro-No");
    }
    else
    {
        Console.WriteLine("No es un numero,¿Deseas Agregar un numero?S-Si Otro-No");
    }
    opcion = Console.ReadLine();
    Console.Clear();
}
foreach (var item in A)
{
    Console.Write("{0} ", item);
}
Console.WriteLine();
int[]B = A.ToArray();
obtenido = algoritmo.MissingInt(B);
Console.WriteLine("El numero faltante es : {0}",obtenido);