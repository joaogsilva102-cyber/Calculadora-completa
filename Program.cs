using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        // Operação de subtração
        int resultado = num1 - num2;

        Console.WriteLine("Resultado: " + resultado);
    }
}