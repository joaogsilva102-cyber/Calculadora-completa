using System;

class Program
{
    static void Main()
    {
        // 1. Correção: Adicionado ';' no final da linha e 'n' minúsculo em num1
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        // 2. Correção: Adicionado ';' e trocado 'Console, ReadLine()' por 'Console.ReadLine()'
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        // 3. Correção: Operação de soma (+) adicionada e nomes de variáveis corrigidos
        int resultado = num1 + num2;

        // 4. Correção: Fechamento das aspas na string e concatenação correta
        Console.WriteLine("Resultado: " + resultado);

    }
}